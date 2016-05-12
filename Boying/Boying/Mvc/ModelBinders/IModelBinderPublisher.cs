using System.Collections.Generic;

namespace Boying.Mvc.ModelBinders
{
    public interface IModelBinderPublisher : IDependency
    {
        void Publish(IEnumerable<ModelBinderDescriptor> binders);
    }
}