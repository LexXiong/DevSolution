using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Boying.Core.Users.Models
{
    public class RegistrationSettingsRecord
    {
        public virtual int Id { get; set; }

        /// <summary>
        /// 用户能否注册
        /// </summary>
        public virtual bool UsersCanRegister { get; set; }

        /// <summary>
        /// 用户必须验证邮箱
        /// </summary>
        public virtual bool UsersMustValidateEmail { get; set; }

        /// <summary>
        /// 验证邮箱的站点名称
        /// </summary>
        public virtual string ValidateEmailRegisteredWebsite { get; set; }

        /// <summary>
        /// 验证邮箱的联系邮件地址
        /// </summary>
        public virtual string ValidateEmailContactEMail { get; set; }

        /// <summary>
        /// 用户是否需要审核
        /// </summary>
        public virtual bool UsersAreModerated { get; set; }

        /// <summary>
        /// 是否需要通知审核
        /// </summary>
        public virtual bool NotifyModeration { get; set; }

        /// <summary>
        /// 通知收件人
        /// </summary>
        public virtual string NotificationsRecipients { get; set; }

        /// <summary>
        /// 是否启用密码找回
        /// </summary>
        public virtual bool EnableLostPassword { get; set; }
    }
}