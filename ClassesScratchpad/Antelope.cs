using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesScratchpad
{
    // Antelope inherits from Animal
    // Antelope derives from Animal
    // Antelope is derived from Animal
    // Antelope is a sub-class, Animal is the super-class
    // Antelope is the derived class, Animal is the base class
    // Antelope is the child class, Animal is the parent class
    // Antelope *is* an animal - Antelope has an *IS-A* relationship with Animal
    internal class Antelope : Animal, IZooMember
    {
        public static int HerdSize { get; set; } = 0;

     
        public int AntlerPoints { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }

        public Antelope(int points, string location) : base("Savannah")
        {
            HerdSize++;
            this.AntlerPoints = points;
            this.Location = location;
        }


        public override void Speak()
        {
            Console.WriteLine("Moo??");
        }

        //public void SpeakAsAGenericAnimal()
        //{
        //    base.Speak();
        //}

        public void Die()
        {
            HerdSize--;
        }


        public static void Stampede()
        {
            
            Console.WriteLine($"{Antelope.HerdSize} antelope all run together, destroying everything in their path!");
        }

        public void SitInCage()
        {
            Console.WriteLine("The antelope sits forlornly, staring out between the bars");
        }
    }
}
