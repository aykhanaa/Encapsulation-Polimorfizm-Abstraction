using Encapsulation_Polimorfizm_Abstraction.Helpers.Constans;
using Encapsulation_Polimorfizm_Abstraction.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Encapsulation_Polimorfizm_Abstraction.Controlles
{
    internal class AccountController
    {
        private readonly AccountService _accountService;
        public AccountController()
        {
            _accountService = new AccountService();
        }

        public void Login()
        {
            Console.WriteLine("Add your email :");
           Email: string email = Console.ReadLine();

            if (email.Contains("@"))
            {
                Console.WriteLine(ResponseMessages.IncorrecEmailFormat);
                goto Email;
            }

            Console.WriteLine("Add your password :");
            string password = Console.ReadLine();

            var response = _accountService.Login(email, password);

            if (response)
            {
                Console.WriteLine(ResponseMessages.LoginSuccess);
            }
            else
            {
                Console.WriteLine(ResponseMessages.LoginFailed);
            } 
        }
    }
}
