using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Polimorfizm_Abstraction.Models
{
    internal class Car
    {
        public string name;
        public int speed;
        private string color="red";
        public string Color { 
            
            get
            {
                if(speed > 400)
                {
                    return color;
                }

                return null;    
                
            }
            set
            {
                color = value;
            }
        
        }


    }
}
