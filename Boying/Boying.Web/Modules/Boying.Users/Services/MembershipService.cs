using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Boying.DisplayManagement;
using Boying.Environment.Configuration;
using Boying.Environment.Extensions;
using Boying.Localization;
using Boying.Logging;
using Boying.Messaging.Services;
using Boying.Security;
using Boying.Services;
using Boying.Settings;
using Boying.Users.Events;

namespace Boying.Users.Services
{
    [BoyingSuppressDependency("Boying.Security.NullMembershipService")]
    public class MembershipService : IMembershipService
    {
        private const string PBKDF2 = "PBKDF2";
        private const string DefaultHashAlgorithm = PBKDF2;

        private readonly IBoyingServices _boyingServices;
        private readonly IMessageService _messageService;
        private readonly IUserEventHandler _userEventHandlers;
        private readonly IEncryptionService _encryptionService;
        private readonly IShapeFactory _shapeFactory;
        private readonly IShapeDisplay _shapeDisplay;
        private readonly IAppConfigurationAccessor _appConfigurationAccessor;
        private readonly IClock _clock;

        public MembershipService(
            IBoyingServices boyingServices,
            IMessageService messageService,
            IUserEventHandler userEventHandlers,
            IClock clock,
            IEncryptionService encryptionService,
            IShapeFactory shapeFactory,
            IShapeDisplay shapeDisplay,
            IAppConfigurationAccessor appConfigurationAccessor)
        {
            _boyingServices = boyingServices;
            _messageService = messageService;
            _userEventHandlers = userEventHandlers;
            _encryptionService = encryptionService;
            _shapeFactory = shapeFactory;
            _shapeDisplay = shapeDisplay;
            _appConfigurationAccessor = appConfigurationAccessor;
            _clock = clock;
            Logger = NullLogger.Instance;
            T = NullLocalizer.Instance;
        }

        public ILogger Logger { get; set; }

        public Localizer T { get; set; }

        public IUser CreateUser(CreateUserParams createUserParams)
        {
            throw new NotImplementedException();
        }

        public MembershipSettings GetSettings()
        {
            var settings = new MembershipSettings();
            // accepting defaults
            return settings;
        }

        public IUser GetUser(string mobile)
        {
            var clearMobile = mobile == null ? "" : mobile.Trim();
        }

        public void SetPassword(IUser user, string password)
        {
            throw new NotImplementedException();
        }

        public IUser ValidateUser(string userNameOrMobile, string password)
        {
            throw new NotImplementedException();
        }
    }
}