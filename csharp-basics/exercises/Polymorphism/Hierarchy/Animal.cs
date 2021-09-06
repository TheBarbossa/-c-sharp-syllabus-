using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public abstract class Animal : Food
    {
        public string animalName
        { get; protected set; }
        public string animalType
        { get; protected set; }
        public double animalWeight
        { get; protected set; }
        public int foodEaten
        { get; protected set; }
        public abstract void makeSound();
        public abstract void eat(Food);
    }
}
