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
            Cow Milka = new Cow();
            Bear Yogi = new Bear();
            Dog Rex = new Dog();

            animals.Add(Milka);
            animals.Add(Yogi);
            animals.Add(Rex);

            ListAnimals(animals);
        }

        private static void ListAnimals(IEnumerable<IAnimal> animals)
        {
            foreach (IAnimal animal in animals)
            {
                Console.Write("The {0} makes {1}", animals.Name(), animals.Sound());
            }
        }
    }
}
