using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class AccountService : IAccountService
    {
        public bool login(string username, string password)
        {
            if (username == "Shaiq1995" && password == "Shaiq1997"){
                return true;
            }
            return false;
        }
    }
}
