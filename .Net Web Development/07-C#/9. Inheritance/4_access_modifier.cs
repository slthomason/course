using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Inheritance
{
    internal class _4_access_modifier
    {
    }

    public class Cycle
    {
        // protected method:
        internal void Pedal()
        {
            Console.WriteLine("Pedal method invoked");
        }

        // private field:
        private int _wheels = 3;

        // protected internal property:
        protected internal int Wheels
        {
            get { return _wheels; }
        }
    }


    // public class:
    public class Tricycle : Cycle
    {
        public void PrintNumberOfWheels()
        {
            Pedal(); // its accessible here.

            //Console.WriteLine("number of wheels are " + _wheels);// comment to see the compile time error

        }
    }



}
