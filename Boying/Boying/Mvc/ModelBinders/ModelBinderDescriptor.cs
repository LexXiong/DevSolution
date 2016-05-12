using System;
using System.Web.Mvc;

namespace Boying.Mvc.ModelBinders
{
    public class ModelBinderDescriptor
    {
        public Type Type { get; set; }

        public IModelBinder ModelBinder { get; set; }
    }
}