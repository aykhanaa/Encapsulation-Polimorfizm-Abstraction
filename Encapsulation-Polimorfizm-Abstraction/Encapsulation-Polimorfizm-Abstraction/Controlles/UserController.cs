using Encapsulation_Polimorfizm_Abstraction.Helpers.Constans;
using Encapsulation_Polimorfizm_Abstraction.Models;
using Encapsulation_Polimorfizm_Abstraction.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Polimorfizm_Abstraction.Controlles
{
    internal class UserController
    {
        private readonly UserService _userService;
        public UserController()
        {
            _userService = new UserService();
        }
        public void GetAll()
        {   
            var response = _userService.GetAll();

            foreach (var user in response)
            {
                string result = $"{user.fullName} - {user.age} - {user.email} ";
                Console.WriteLine(result);
            }
        }

        public void GetById()
        {
            Console.WriteLine("Enter user id ");
            UserId: string strId = Console.ReadLine();

            int id;

            bool isCorrectId = int.TryParse(strId, out id);

            if (isCorrectId)
            {
                var user = _userService.GetById(_userService.GetAll(), id);
                if (user == null)
                {
                    Console.WriteLine(ResponseMessages.Noffound);
                    return;
                }

                string result = $"{user.fullName} - {user.age} - {user.email} ";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(ResponseMessages.IncorrecNumberFormat);
                goto UserId;
            }





         
        }

    }
}
