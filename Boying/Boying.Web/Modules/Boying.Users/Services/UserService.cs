using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Boying.Environment.Configuration;
using Boying.Localization;
using Boying.Logging;
using Boying.Messaging.Services;
using Boying.Services;
using Boying.Settings;
using Boying.Users.Events;

namespace Boying.Users.Services
{
    public class UserService : IUserService
    {
        private readonly IClock _clock;
        private readonly IMessageService _messageService;
        private readonly ISiteService _siteService;

        public UserService(
            IClock clock,
            IMessageService messageService,
            ISiteService siteService)
        {
            _clock = clock;
            _messageService = messageService;
            _siteService = siteService;
            Logger = NullLogger.Instance;
            T = NullLocalizer.Instance;
        }

        public ILogger Logger { get; set; }

        public Localizer T { get; set; }

        public bool VerifyUserUnicity(string mobile)
        {
            throw new NotImplementedException();
        }

        public bool VerifyUserUnicity(int id, string mobile)
        {
            throw new NotImplementedException();
        }
    }
}