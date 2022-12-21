using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks12._21._2022.Controllers
{
    internal class AccountController
    {
        public void login()
        {
            AccountService accountservice = new AccountService();


            Console.WriteLine("Add Username :");
            string username =Console.ReadLine();
            Console.WriteLine("Add Password :");
            string password =Console.ReadLine();

            var result=accountservice.login(username,password);

            if (result)
            {
                Console.WriteLine("Giris ugurludur");
            }
            else
            {
                Console.WriteLine("Username ve ya password sehfdir");
            }
        }
    }
}
