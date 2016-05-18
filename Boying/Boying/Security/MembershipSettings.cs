using System.Web.Security;

namespace Boying.Security
{
    /// <summary>
    /// ��Ա����
    /// </summary>
    public class MembershipSettings
    {
        /// <summary>
        /// ��Ա����
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
        /// ��������ָ�
        /// </summary>
        public bool EnablePasswordRetrieval { get; set; }

        /// <summary>
        /// ������������
        /// </summary>
        public bool EnablePasswordReset { get; set; }

        /// <summary>
        /// �������Ч�������
        /// </summary>
        public int MaxInvalidPasswordAttempts { get; set; }

        /// <summary>
        /// ���볢�Դ���
        /// </summary>
        public int PasswordAttemptWindow { get; set; }

        /// <summary>
        /// ��ҪΨһ���ֻ���
        /// </summary>
        public bool RequiresUniqueMobile { get; set; }

        /// <summary>
        /// �����ʽ
        /// </summary>
        public MembershipPasswordFormat PasswordFormat { get; set; }

        /// <summary>
        /// ��Ҫ����С���볤��
        /// </summary>
        public int MinRequiredPasswordLength { get; set; }

        /// <summary>
        /// ��Ҫ�����ٷ���ĸ�����ַ���
        /// </summary>
        public int MinRequiredNonAlphanumericCharacters { get; set; }

        /// <summary>
        /// ����ǿ�ȵ�������ʽ
        /// </summary>
        public string PasswordStrengthRegularExpression { get; set; }
    }
}