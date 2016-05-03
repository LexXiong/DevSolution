using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSolution.Logging
{
    public class CastleLoggerFactory : ILoggerFactory
    {
        private readonly Castle.Core.Logging.ILoggerFactory _castleLoggerFactory;

        public CastleLoggerFactory(Castle.Core.Logging.ILoggerFactory castleLoggerFactory)
        {
            _castleLoggerFactory = castleLoggerFactory;
        }

        public ILogger CreateLogger(Type type)
        {
            return new CastleLogger(_castleLoggerFactory.Create(type));
        }
    }
}
