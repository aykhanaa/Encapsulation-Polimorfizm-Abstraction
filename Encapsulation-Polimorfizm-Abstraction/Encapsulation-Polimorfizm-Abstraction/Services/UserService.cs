using Encapsulation_Polimorfizm_Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Polimorfizm_Abstraction.Services
{
    internal class UserService
    {
        public User[] GetAll()
        {
            return new User[]
            {
                new User
                {
                    id = 1,
                    fullName = "Fatime Qayxanova",
                    age = 22,
                    email = "fatime@code.edu.az",
                    password = "fatime123",
                },
                new User
                {
                    id = 2,
                    fullName = "Fexriyye Tagizade",
                    age = 21,
                    email = "faxriyye@code.edu.az",
                    password = "faxriyye123",
                },
                new User
                {
                    id = 3,
                    fullName = "Emirastan Miriyev",
                    age = 33,
                    email = "emirastan@code.edu.az",
                    password = "emirastan123",
                },
            };
        }

        public User GetById(User[] users,int id)
        {
            return users.Where( m => m.id == id).FirstOrDefault();
        }
    }
}
