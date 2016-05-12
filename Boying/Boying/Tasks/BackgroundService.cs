using System;
using System.Collections.Generic;
using Boying.Data;
using Boying.Environment.Configuration;
using Boying.Exceptions;
using Boying.Logging;

namespace Boying.Tasks
{
    public interface IBackgroundService : IDependency
    {
        void Sweep();
    }

    public class BackgroundService : IBackgroundService
    {
        private readonly IEnumerable<IBackgroundTask> _tasks;
        private readonly ITransactionManager _transactionManager;
        private readonly string _shellName;

        public BackgroundService(
            IEnumerable<IBackgroundTask> tasks,
            ITransactionManager transactionManager,
            ShellSettings shellSettings)
        {
            _tasks = tasks;
            _transactionManager = transactionManager;
            _shellName = shellSettings.Name;
            Logger = NullLogger.Instance;
        }

        public ILogger Logger { get; set; }

        public void Sweep()
        {
            foreach (var task in _tasks)
            {
                var taskName = task.GetType().FullName;

                try
                {
                    Logger.Information("Start processing background task \"{0}\" on tenant \"{1}\".", taskName, _shellName);
                    _transactionManager.RequireNew();
                    task.Sweep();
                    Logger.Information("Finished processing background task \"{0}\" on tenant \"{1}\".", taskName, _shellName);
                }
                catch (Exception ex)
                {
                    if (ex.IsFatal())
                    {
                        throw;
                    }

                    _transactionManager.Cancel();
                    Logger.Error(ex, "Error while processing background task \"{0}\" on tenant \"{1}\".", taskName, _shellName);
                }
            }
        }
    }
}