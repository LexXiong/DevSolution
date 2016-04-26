using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSolution
{
    /// <summary>
    /// 基本接口服务实例化每个工作单元(即web请求)。
    /// </summary>
    public interface IDependency
    {
    }

    /// <summary>
    /// 基本接口服务实例化每个 shell/tenant。
    /// </summary>
    public interface ISingletonDependency : IDependency
    {
    }

    /// <summary>
    /// 基本接口服务，“只能” 被实例化在一个工作单元中。
    /// 这个接口是用来保证实例不是被意外的引用做单例的依赖
    /// </summary>
    public interface IUnitOfWorkDependency : IDependency
    {
    }

    /// <summary>
    /// Base interface for services that are instantiated per usage.
    /// </summary>
    public interface ITransientDependency : IDependency
    {
    }
}