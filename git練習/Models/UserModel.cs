using System;

namespace git練習.Models
{
    public class UserModel
    {
        public String UserName { get; set; }
        public String Account { get; set; }
        public String Password { get; set; }
        public int Age { get; set; }

        public UserModel()
        {
            
        }

        public UserModel(string userName, string account, string password, int age)
        {
            UserName = userName;
            Account = account;
            Password = password;
            Age = age;
        }
    }
}