using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_exception_handling
{
    public class DivByZero : Exception
    {

        // Constructor
        public DivByZero()
        {
            Console.Write("Exception has occurred : ");
        }
    }

    public class calculator
    {

        public double DivisionOperation(double numerator,
                                 double denominator)
        {
            // throw exception when denominator
            // value is 0
            if (denominator == 0)
                throw new DivByZero();

            // Otherwise return the result of the division
            return numerator / denominator;
        }
    }
}
