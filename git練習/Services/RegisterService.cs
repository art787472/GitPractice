using git練習.Models;

namespace git練習.Services
{
    public class RegisterService
    {
        private UserModel model = null;
        public RegisterService()
        {
            model = new UserModel();
        }
    
        public bool Register(string Account,string Password,string UserName)
        {
            if (!CheckAccountExist(Account))
                return false;
            model.Account = Account;
            model.Password = Password;
            model.UserName = UserName;
            return true;
        }

        private bool CheckAccountExist(string Account)
        {
            return true;
        }
    }
}