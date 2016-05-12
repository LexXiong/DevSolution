using System;
using System.Linq;
using Boying.Commands;
using Boying.Data.Migration;
using Boying.Environment.Extensions;

namespace Boying.Migrations.Commands
{
    [BoyingFeature("Boying.Migrations")]
    public class DataMigrationCommands : DefaultBoyingCommandHandler
    {
        private readonly IDataMigrationManager _dataMigrationManager;
        private readonly IExtensionManager _extensionManager;

        public DataMigrationCommands(
            IDataMigrationManager dataMigrationManager,
            IExtensionManager extensionManager
            )
        {
            _dataMigrationManager = dataMigrationManager;
            _extensionManager = extensionManager;
        }

        [CommandName("upgrade database")]
        [CommandHelp("upgrade database <feature-name-1> ... <feature-name-n> \r\n\t" + "Upgrades or create the database tables for the <feature-name> or all features if not available")]
        public void UpgradeDatabase(params string[] featureNames)
        {
            var features = featureNames.Any()
                                   ? featureNames
                                   : _extensionManager.AvailableExtensions()
                                         .SelectMany(ext => ext.Features)
                                         .Select(f => f.Id);
            try
            {
                foreach (var feature in features)
                {
                    _dataMigrationManager.Update(feature);
                }
            }
            catch (Exception ex)
            {
                throw new BoyingException(T("An error occured while upgrading the database."), ex);
            }

            Context.Output.WriteLine(T("Database upgraded"));
        }
    }
}