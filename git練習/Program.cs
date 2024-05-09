using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using git練習.Services;

namespace git練習
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string account = Console.ReadLine();
            string password = Console.ReadLine();
            string userName = Console.ReadLine();
            RegisterService service = new RegisterService();
            bool isSuccess = service.Register(account, password, userName);
            if (isSuccess)
            {
                Console.Write("登入成功!!");
            }
            else
            {
                Console.WriteLine("登入失敗");
            }
            LoginFunction loginFunction = new LoginFunction();

            

            var (isLoginSuccess, loginMessage) = loginFunction.Login(account, password, userName);
            Console.WriteLine(loginMessage);

            loginFunction.Logout();

            Console.ReadKey();
        }
    }
}
