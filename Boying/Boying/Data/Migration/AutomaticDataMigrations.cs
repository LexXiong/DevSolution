using System;
using System.Linq;
using Boying.Data.Migration.Interpreters;
using Boying.Data.Migration.Schema;
using Boying.Environment;
using Boying.Environment.Configuration;
using Boying.Environment.Features;
using Boying.Exceptions;
using Boying.Logging;
using Boying.Tasks.Locking.Services;

namespace Boying.Data.Migration
{
    /// <summary>
    /// Registers to BoyingShell.Activated in order to run migrations automatically
    /// </summary>
    public class AutomaticDataMigrations : IBoyingShellEvents
    {
        private readonly IDataMigrationManager _dataMigrationManager;
        private readonly IFeatureManager _featureManager;
        private readonly IDistributedLockService _distributedLockService;
        private readonly IDataMigrationInterpreter _dataMigrationInterpreter;
        private readonly ShellSettings _shellSettings;
        private readonly ITransactionManager _transactionManager;

        public AutomaticDataMigrations(
            IDataMigrationManager dataMigrationManager,
            IDataMigrationInterpreter dataMigrationInterpreter,
            IFeatureManager featureManager,
            IDistributedLockService distributedLockService,
            ITransactionManager transactionManager,
            ShellSettings shellSettings)
        {
            _dataMigrationManager = dataMigrationManager;
            _featureManager = featureManager;
            _distributedLockService = distributedLockService;
            _shellSettings = shellSettings;
            _transactionManager = transactionManager;
            _dataMigrationInterpreter = dataMigrationInterpreter;

            Logger = NullLogger.Instance;
        }

        public ILogger Logger { get; set; }

        public void Activated()
        {
            EnsureDistributedLockSchemaExists();

            IDistributedLock @lock;
            if (_distributedLockService.TryAcquireLock(GetType().FullName, TimeSpan.FromMinutes(30), TimeSpan.FromMilliseconds(250), out @lock))
            {
                using (@lock)
                {
                    // Let's make sure that the basic set of features is enabled.  If there are any that are not enabled, then let's enable them first.
                    var theseFeaturesShouldAlwaysBeActive = new[] {
                        "Settings", "Shapes",
                    };

                    var enabledFeatures = _featureManager.GetEnabledFeatures().Select(f => f.Id).ToList();
                    var featuresToEnable = theseFeaturesShouldAlwaysBeActive.Where(shouldBeActive => !enabledFeatures.Contains(shouldBeActive)).ToList();
                    if (featuresToEnable.Any())
                    {
                        _featureManager.EnableFeatures(featuresToEnable, true);
                    }

                    foreach (var feature in _dataMigrationManager.GetFeaturesThatNeedUpdate())
                    {
                        try
                        {
                            _dataMigrationManager.Update(feature);
                        }
                        catch (Exception ex)
                        {
                            if (ex.IsFatal())
                            {
                                throw;
                            }
                            Logger.Error("Could not run migrations automatically on " + feature, ex);
                        }
                    }
                }
            }
        }

        public void Terminating()
        {
            // No-op.
        }

        /// <summary>
        /// This ensures that the framework migrations have run for the distributed locking feature, as existing Boying installations will not have the required tables when upgrading.
        /// </summary>
        private void EnsureDistributedLockSchemaExists()
        {
            // Ensure the distributed lock record schema exists.
            var schemaBuilder = new SchemaBuilder(_dataMigrationInterpreter);
            var distributedLockSchemaBuilder = new DistributedLockSchemaBuilder(_shellSettings, schemaBuilder);
            if (!distributedLockSchemaBuilder.SchemaExists())
            {
                // Workaround to avoid some Transaction issue for PostgreSQL.
                _transactionManager.RequireNew();
                distributedLockSchemaBuilder.CreateSchema();
            }
        }
    }
}