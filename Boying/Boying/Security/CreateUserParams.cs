namespace Boying.Security
{
    //TEMP: Add setters, provide default constructor and remove parameterized constructor
    public class CreateUserParams
    {
        private readonly string _password;
        private readonly string _email;
        private readonly string _mobile;
        private readonly string _nickname;
        private readonly bool _isApproved;

        public CreateUserParams(string nickname, string mobile, string email, string password, bool isApproved)
        {
            _nickname = nickname;
            _password = password;
            _mobile = mobile;
            _email = email;
            _isApproved = isApproved;
        }

        public string NickName
        {
            get
            {
                return _nickname;
            }
        }

        public string Password
        {
            get { return _password; }
        }

        public string Email
        {
            get { return _email; }
        }

        public string Mobile
        {
            get { return _mobile; }
        }

        public bool IsApproved
        {
            get { return _isApproved; }
        }
    }
}