﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : IAnimal
    {
        public string MakesSound()
        {
            return "Ham!";
        }
    }
}
