using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Bear : IAnimal
    {
        public string Name()
        {
            return "Bear";
        }

        public string Sound()
        {
            return "Mor!";
        }
    }
}
