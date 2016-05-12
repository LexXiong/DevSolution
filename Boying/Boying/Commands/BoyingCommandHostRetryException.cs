using System;
using System.Runtime.Serialization;
using Boying.Localization;

namespace Boying.Commands
{
    [Serializable]
    public class BoyingCommandHostRetryException : BoyingCoreException
    {
        public BoyingCommandHostRetryException(LocalizedString message)
            : base(message)
        {
        }

        public BoyingCommandHostRetryException(LocalizedString message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected BoyingCommandHostRetryException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}