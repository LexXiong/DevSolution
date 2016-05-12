using System;
using System.Runtime.Serialization;
using Boying.Localization;

namespace Boying
{
    [Serializable]
    public class BoyingFatalException : Exception
    {
        private readonly LocalizedString _localizedMessage;

        public BoyingFatalException(LocalizedString message)
            : base(message.Text)
        {
            _localizedMessage = message;
        }

        public BoyingFatalException(LocalizedString message, Exception innerException)
            : base(message.Text, innerException)
        {
            _localizedMessage = message;
        }

        protected BoyingFatalException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public LocalizedString LocalizedMessage { get { return _localizedMessage; } }
    }
}