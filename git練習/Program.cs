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
            bool isSuccess = service.Register(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            if (!isSuccess)
            {
                Console.Write("登入成功!!");
            }
            Console.ReadKey();
        }
    }
}
