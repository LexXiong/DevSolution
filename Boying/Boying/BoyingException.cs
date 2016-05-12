using System;
using System.Runtime.Serialization;
using Boying.Localization;

namespace Boying
{
    [Serializable]
    public class BoyingException : ApplicationException
    {
        private readonly LocalizedString _localizedMessage;

        public BoyingException(LocalizedString message)
            : base(message.Text)
        {
            _localizedMessage = message;
        }

        public BoyingException(LocalizedString message, Exception innerException)
            : base(message.Text, innerException)
        {
            _localizedMessage = message;
        }

        protected BoyingException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public LocalizedString LocalizedMessage { get { return _localizedMessage; } }
    }
}