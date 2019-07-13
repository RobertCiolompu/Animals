using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<IAnimal>();
        }

        private void ListAnimals(List<IAnimal> animals)
        {
            foreach (IAnimal element in animals)
            {
                Console.Write("The {0} makes {1}", animals.Name(), animals.Sound());
            }
        }
    }
}
