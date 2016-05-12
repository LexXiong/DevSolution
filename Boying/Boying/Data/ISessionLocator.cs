using System;
using NHibernate;

namespace Boying.Data
{
    public interface ISessionLocator : IDependency
    {
        [Obsolete("Use ITransactionManager.GetSession() instead.")]
        ISession For(Type entityType);
    }
}