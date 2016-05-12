using System;
using System.Runtime.Serialization;
using Boying.Localization;

namespace Boying
{
    [Serializable]
    public class BoyingCoreException : Exception
    {
        private readonly LocalizedString _localizedMessage;

        public BoyingCoreException(LocalizedString message)
            : base(message.Text)
        {
            _localizedMessage = message;
        }

        public BoyingCoreException(LocalizedString message, Exception innerException)
            : base(message.Text, innerException)
        {
            _localizedMessage = message;
        }

        protected BoyingCoreException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public LocalizedString LocalizedMessage { get { return _localizedMessage; } }
    }
}