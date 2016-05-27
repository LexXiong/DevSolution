namespace Boying.Security
{
    public interface IMembershipService : IDependency
    {
        MembershipSettings GetSettings();

        IUser CreateUser(CreateUserParams createUserParams);

        IUser GetUser(string mobile);

        IUser ValidateUser(string mobileOrEmail, string password);

        void SetPassword(IUser user, string password);
    }
}