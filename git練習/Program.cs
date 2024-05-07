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
            RegisterService service = new RegisterService();
            bool isSuccess = service.Register("leo604leo604@gmail.com", "abc1234", "Leo");
            if(isSuccess)
                Console.Write("登入成功");
            else 
                Console.WriteLine("登入失敗");
            Console.ReadKey();
        }
    }
}
