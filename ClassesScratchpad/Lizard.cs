using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesScratchpad
{
    class Lizard : Animal
    {
        public Lizard() : base("Scales")
        {
            
        }

        public override void Speak()
        {
            Console.WriteLine("Hiss");
        }
    }
}
