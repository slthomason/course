using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_encapsulation_abstraction
{
    public class _1_encapsulation
    {

        // private variables declared
        // these can only be accessed by
        // public methods of class
        private string _studentName;
        private int _studentAge;

        // using accessors to get and 
        // set the value of studentName
        public string Name
        {

            get
            {
                return _studentName;
            }

            set
            {
                _studentName = value;
            }

        }

        // using accessors to get and 
        // set the value of studentAge
        public int Age
        {

            get
            {
                return _studentAge;
            }

            set
            {
                _studentAge = value = 5;
            }

        }


    }
}
