using System.Collections.Generic;
using Boying.DisplayManagement.Shapes;

namespace Boying.DisplayManagement
{
    public interface IShapeDisplay : IDependency
    {
        string Display(Shape shape);

        string Display(object shape);

        IEnumerable<string> Display(IEnumerable<object> shapes);
    }
}