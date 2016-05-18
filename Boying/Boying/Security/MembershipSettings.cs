using System.Web.Security;

namespace Boying.Security
{
    /// <summary>
    /// 成员设置
    /// </summary>
    public class MembershipSettings
    {
        /// <summary>
        /// 成员设置
        /// </summary>
        public MembershipSettings()
        {
            EnablePasswordRetrieval = false;
            EnablePasswordReset = true;
            RequiresUniqueMobile = true;
            MaxInvalidPasswordAttempts = 5;
            PasswordAttemptWindow = 10;
            MinRequiredPasswordLength = 7;
            MinRequiredNonAlphanumericCharacters = 1;
            PasswordStrengthRegularExpression = "";
            PasswordFormat = MembershipPasswordFormat.Hashed;
        }

        /// <summary>
        /// 启用密码恢复
        /// </summary>
        public bool EnablePasswordRetrieval { get; set; }

        /// <summary>
        /// 启用密码重置
        /// </summary>
        public bool EnablePasswordReset { get; set; }

        /// <summary>
        /// 最大尝试无效密码次数
        /// </summary>
        public int MaxInvalidPasswordAttempts { get; set; }

        /// <summary>
        /// 密码尝试窗口
        /// </summary>
        public int PasswordAttemptWindow { get; set; }

        /// <summary>
        /// 需要唯一的手机号
        /// </summary>
        public bool RequiresUniqueMobile { get; set; }

        /// <summary>
        /// 密码格式
        /// </summary>
        public MembershipPasswordFormat PasswordFormat { get; set; }

        /// <summary>
        /// 需要的最小密码长度
        /// </summary>
        public int MinRequiredPasswordLength { get; set; }

        /// <summary>
        /// 需要的最少非字母数字字符数
        /// </summary>
        public int MinRequiredNonAlphanumericCharacters { get; set; }

        /// <summary>
        /// 密码强度的正则表达式
        /// </summary>
        public string PasswordStrengthRegularExpression { get; set; }
    }
}