using System.Data;
using System.Web.Http.Filters;
using System.Web.Mvc;
using Boying.Mvc.Filters;
using Boying.WebApi.Filters;
using NHibernate;

namespace Boying.Data
{
    public interface ITransactionManager : IDependency
    {
        void Demand();

        void RequireNew();

        void RequireNew(IsolationLevel level);

        void Cancel();

        ISession GetSession();
    }

    public class TransactionFilter : FilterProvider, System.Web.Mvc.IExceptionFilter
    {
        private readonly ITransactionManager _transactionManager;

        public TransactionFilter(ITransactionManager transactionManager)
        {
            _transactionManager = transactionManager;
        }

        public void OnException(ExceptionContext filterContext)
        {
            _transactionManager.Cancel();
        }
    }

    public class WebApiTransactionFilter : ExceptionFilterAttribute, IApiFilterProvider
    {
        private readonly ITransactionManager _transactionManager;

        public WebApiTransactionFilter(ITransactionManager transactionManager)
        {
            _transactionManager = transactionManager;
        }

        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            _transactionManager.Cancel();
        }
    }
}