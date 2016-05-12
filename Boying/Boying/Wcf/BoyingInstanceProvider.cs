using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using Autofac.Core;

namespace Boying.Wcf
{
    public class BoyingInstanceProvider : IInstanceProvider
    {
        private readonly IWorkContextAccessor _workContextAccessor;
        private readonly IComponentRegistration _componentRegistration;

        public BoyingInstanceProvider(IWorkContextAccessor workContextAccessor, IComponentRegistration componentRegistration)
        {
            _workContextAccessor = workContextAccessor;
            _componentRegistration = componentRegistration;
        }

        public object GetInstance(InstanceContext instanceContext, Message message)
        {
            BoyingInstanceContext item = new BoyingInstanceContext(_workContextAccessor);
            instanceContext.Extensions.Add(item);
            return item.Resolve(_componentRegistration);
        }

        public object GetInstance(InstanceContext instanceContext)
        {
            return GetInstance(instanceContext, null);
        }

        public void ReleaseInstance(InstanceContext instanceContext, object instance)
        {
            BoyingInstanceContext context = instanceContext.Extensions.Find<BoyingInstanceContext>();
            if (context != null)
            {
                context.Dispose();
            }
        }
    }
}