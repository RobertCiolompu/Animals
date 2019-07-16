using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cow : IAnimal
    {
        public string MakesSound()
        {
            return "Moo!";
        }
    }
}
