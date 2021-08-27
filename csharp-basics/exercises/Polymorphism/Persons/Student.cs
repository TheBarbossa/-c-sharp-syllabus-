using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Student : Person
    {
        public double _gpa
        { get; protected set; }

        public Student(string firstName, string lastName, string address, int id, double gpa) :base(firstName, lastName, address, id)
        {
            _gpa = gpa;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {_firstName}, Last name: {_lastName}, Address: {_address}, ID number: {_id}, Students GPA: {_gpa}");
        }
    }
}
