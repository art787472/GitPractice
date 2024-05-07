using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git練習
{
    internal class LoginFunction
    {
        public (bool, string) Login(User user)
        {
            if (!Verify(user))
                return (false, "登入失敗");
            return (true, "登入成功");

        }

        public void Logout()
        {
            return;
        }

        public bool Verify(User user)
        {
            string id = user.id;
            string email = user.email;
            if (string.IsNullOrEmpty(id))
            {
                return false;
            }
            if (!email.Contains("@"))
            {
                return false;
            }
            return true;
        }

       
    }
}
