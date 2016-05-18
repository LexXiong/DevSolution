namespace Boying.Security
{
    //TEMP: Add setters, provide default constructor and remove parameterized constructor
    public class CreateUserParams
    {
        private readonly string _username;
        private readonly string _password;
        private readonly string _mobile;
        private readonly bool _isApproved;

        public CreateUserParams(string username, string password, string mobile, bool isApproved)
        {
            _username = username;
            _password = password;
            _mobile = mobile;
            _isApproved = isApproved;
        }

        public string Username
        {
            get { return _username; }
        }

        public string Password
        {
            get { return _password; }
        }

        public string Email
        {
            get { return _mobile; }
        }

        public bool IsApproved
        {
            get { return _isApproved; }
        }
    }
}