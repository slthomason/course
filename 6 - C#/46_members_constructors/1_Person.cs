using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_members_constructors
{
    
    public class Person
    {
        // field members
        private string FirstName = "Spencer";
        private string LastName = "Thomason";


        // method members
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
