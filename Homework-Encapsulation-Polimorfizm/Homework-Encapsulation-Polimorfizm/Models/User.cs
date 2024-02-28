using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Encapsulation_Polimorfizm.Models
{
    internal class User
    {
        public string name;
        public string surname;
        public int age;
        private string passsword;

        public User(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public string GetPassword()
        {
            return passsword;
        }
        public void SetPassword(string passsword)
        {
            this.passsword = passsword;
        }
    }
}
