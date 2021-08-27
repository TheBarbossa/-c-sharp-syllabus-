using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Employee : Person
    {
        public string _jobTitle
        { get; protected set; }

        public Employee(string firstName, string lastName, string address, int id, string jobTitle) : base(firstName, lastName, address, id)
        {
            _jobTitle = jobTitle;
        }
        public override void Display()
        {
            Console.WriteLine($"Name: {_firstName}, Last name: {_lastName}, Address: {_address}, ID number: {_id}, Job title: {_jobTitle}");
        }
    }
}
