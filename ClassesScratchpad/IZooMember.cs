using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesScratchpad
{
    public interface IZooMember
    {
        string Name { get; set; }

        void Eat(string food);

        void SitInCage();
    }
}
