using Boying.Environment.Extensions.Models;

namespace Boying.Data.Migration
{
    public interface IDataMigration : IDependency
    {
        Feature Feature { get; }
    }
}