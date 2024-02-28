using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Polimorfizm_Abstraction.Models
{
    internal class Bird:Animal
    {
         public string Color {  get; set; }

        public override void Sound()
        {
            Console.WriteLine("Bird sound");
        }
    }
}
