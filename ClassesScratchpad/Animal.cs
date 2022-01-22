using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesScratchpad
{
    public class Animal
    {
        public int Age { get; protected set; }
        public string HairType { get; set; }
        public int HeightInches { get; set; }
        public string Color { get; set; }
        public string Habitat { get; set; }

        public Animal(string habitat)
        {
            Habitat = habitat;
        }


        public virtual void Speak()
        {
            Console.WriteLine("Animal makes some kind of noise");
        }

        //abstract public void Speak();

        public void Eat(string food)
        {
            Console.WriteLine("Animal eats " + food);
        }

    }
}
