using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boying.Users.Services
{
    public interface IUserService : IDependency
    {
        /// <summary>
        /// 通过手机号码验证用户的唯一性
        /// </summary>
        /// <param name="mobile">手机号码</param>
        /// <returns></returns>
        bool VerifyUserUnicity(string mobile);

        /// <summary>
        /// 通过手机号码验证用户的唯一性，且不包含指定的用户
        /// </summary>
        /// <param name="id">指定的用户</param>
        /// <param name="mobile">手机号码</param>
        /// <returns></returns>
        bool VerifyUserUnicity(int id, string mobile);
    }
}