using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._1
{
        class Legk : Avto // клас легковий
        {
            public Legk(string name, Color color, uint gruzp) : base(name, color, gruzp)
            {
                Console.WriteLine("Створено легковий автомобiль");
            }
        }

        class Gruz : Avto // клас грузовий
        {
            public Gruz(string name, Color color, uint gruzp) : base(name, color, gruzp)
            {
                Console.WriteLine("Створено грузовий автомобiль");
            }
        }
}
