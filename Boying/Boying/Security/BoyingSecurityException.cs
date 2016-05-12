using System;
using System.Runtime.Serialization;
using Boying.Localization;

namespace Boying.Security
{
    [Serializable]
    public class BoyingSecurityException : BoyingCoreException
    {
        public BoyingSecurityException(LocalizedString message) : base(message)
        {
        }

        public BoyingSecurityException(LocalizedString message, Exception innerException) : base(message, innerException)
        {
        }

        protected BoyingSecurityException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public string PermissionName { get; set; }

        public IUser User { get; set; }

        //public IContent Content { get; set; }
    }
}