using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Person
    {
        public string _firstName
        { get; private set; }
        public string _lastName
        { get; private set; }
        public string _address
        { get; private set; }
        public int _id
        { get; private set; }
        public Person(){}

        public Person(string firstName, string lastName, string address, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _id = id;
        }
        public virtual void Display()
        {
            Console.WriteLine($"Name: {_firstName}, Last name: {_lastName}, Address: {_address}, ID number: {_id}");
        }
    }
}
