using System.Collections.Generic;
using System.Reflection;

namespace Boying.Environment
{
    public interface IBoyingFrameworkAssemblies : IDependency
    {
        IEnumerable<AssemblyName> GetFrameworkAssemblies();
    }

    public class DefaultBoyingFrameworkAssemblies : IBoyingFrameworkAssemblies
    {
        public IEnumerable<AssemblyName> GetFrameworkAssemblies()
        {
            return typeof(IDependency).Assembly.GetReferencedAssemblies();
        }
    }
}