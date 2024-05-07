using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git練習
{
    internal class LoginFunction
    {
        public void Login(User user)
        {
            return;
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
