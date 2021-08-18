using System;
using System.ComponentModel.DataAnnotations;

namespace Exercise7
{
    class DogTest
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog("Max","male","Lady","Rocky");
            Dog d2 = new Dog("Rocky", "male","Molly","Sam");
            Dog d3 = new Dog("Sparky", "male");
            Dog d4 = new Dog("Buster", "male","Lady","Sparky");
            Dog d5 = new Dog("Sam", "male");
            Dog d6 = new Dog("Lady", "female");
            Dog d7 = new Dog("Molly", "female");
            Dog d8 = new Dog("Coco", "female","Molly","Buster");

            d8.fathersName();
            d3.fathersName();
            Console.WriteLine(d2.HasSameMotherAs(d8));
            Console.WriteLine(d1.HasSameMotherAs(d2));
            Console.ReadKey();
        }
    }
}
