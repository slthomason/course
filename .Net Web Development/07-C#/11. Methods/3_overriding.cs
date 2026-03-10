using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_methods
{
    class baseClass

    {
        public void show()
        {
            Console.WriteLine("Base class");
        }
    }

    // derived class name 'derived'
    // 'baseClass' inherit here
    class derived : baseClass
    {

        // overriding
        new public void show()
        {
            Console.WriteLine("Derived class");
        }
    }




    class baseClassWithVirtual
    {

        // show() is 'virtual' here
        public virtual void show()
        {
            Console.WriteLine("Base class");
        }
    }


    // class 'baseClass' inherit
    // class 'derived'
    class derivedWithOveride : baseClassWithVirtual
    {

        //'show()' is 'override' here
        public override void show()
        {
            Console.WriteLine("Derived class");
        }
    }
}
