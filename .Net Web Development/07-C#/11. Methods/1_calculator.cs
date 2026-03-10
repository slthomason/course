using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_methods
{
    internal class _1_calculator
    {

        // no input and output
        public void printSumOf2And2()
        {
            int a = 2, b = 2, add;
            add = a + b;
            Console.WriteLine(add);
        }

        // no input but have output
        public int sumOf2And2()
        {
            int a = 2, b = 2, add;
            add = a + b;
            return add;
        }


        // both input and output
        public int Sum(int x, int y)
        {

            // there are two local variables
            // 'a' and 'b' where 'a' is assigned
            // the value of parameter 'x' and
            // 'b' is assigned the value of
            // parameter 'y'
            int a = x;
            int b = y;

            // The local variable calculates
            // the sum of 'a' and 'b'
            // and returns the result
            // which is of 'int' type.
            int result = a + b;

            return result;
        }

        // overloading of method with 3 
        public int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

    }
}
