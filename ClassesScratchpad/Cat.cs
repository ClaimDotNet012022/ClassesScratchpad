using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesScratchpad
{
    internal class Cat : Animal
    {
        public string Name { get; set; }

        //public int Age { get; set; } = 0;

        //public string Color { get; set; } = "Black";

        //public string HairType { get; set; }

        public Cat() : base("Any")
        {

        }

        public override void Speak()
        {
            Console.WriteLine("Meow!");
        }

        public void PrintName()
        {
            Console.WriteLine(this.Name);
        }
    }
}
