using System.Collections.Generic;

namespace Boying.Mvc.ModelBinders
{
    public interface IModelBinderProvider : IDependency
    {
        IEnumerable<ModelBinderDescriptor> GetModelBinders();
    }
}