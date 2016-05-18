using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Boying.Security;
using Boying.Services;

namespace Boying.Users.Events
{
    public class UserEventHandler : IUserEventHandler
    {
        private readonly IClock _clock;

        public UserEventHandler(IClock clock)
        {
            _clock = clock;
        }

        public void AccessDenied(IUser user)
        {
        }

        public void Approved(IUser user)
        {
        }

        public void ChangedPassword(IUser user)
        {
        }

        public void ConfirmedEmail(IUser user)
        {
        }

        public void Created(UserContext context)
        {
        }

        public void Creating(UserContext context)
        {
        }

        public void LoggedIn(IUser user)
        {
        }

        public void LoggedOut(IUser user)
        {
        }

        public void LoggingIn(string userNameOrMobile, string password)
        {
        }

        public void LogInFailed(string userNameOrMobile, string password)
        {
        }

        public void SentChallengeEmail(IUser user)
        {
        }
    }
}