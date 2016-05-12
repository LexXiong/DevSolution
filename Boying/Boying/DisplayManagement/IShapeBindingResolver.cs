using System.Collections.Generic;
using Boying.DisplayManagement.Descriptors;

namespace Boying.DisplayManagement
{
    public interface IShapeBindingResolver : IDependency
    {
        bool TryGetDescriptorBinding(string shapeType, out ShapeBinding shapeBinding);
    }
}