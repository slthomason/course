using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_members_constructors
{
    public class Employee
    {
        // properties example 1
        private string _firstName;
             
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }


        // properties example 2
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }


        public string GetFullName()
        {
            return _firstName + " " + LastName;
        }

        // default construtor
        public Employee()
        {
            _firstName = "Spencer";
            _lastName = "Thomason";
        }


        // Parameterized construtor
        public Employee(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }


        // Parameterized construtor
        public Employee(Employee employee)
        {
            _firstName = employee.FirstName;
            _lastName = employee.LastName;
        }

        // destructor
        ~Employee()
        {
            Console.WriteLine("Destructor was called");
        }

    }
}
