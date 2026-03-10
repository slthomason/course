using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_encapsulation_abstraction
{
    // interface declaration
    interface Vehicle
    {

        // all are the abstract methods.
        void changeGear(int a);
        void speedUp(int a);
        void applyBrakes(int a);
    }

    // class implements interface
    class Bicycle : Vehicle
    {
        int speed;
        int gear;

        // to change gear
        public void changeGear(int newGear)
        {

            gear = newGear;
        }

        // to increase speed
        public void speedUp(int increment)
        {

            speed = speed + increment;
        }

        // to decrease speed
        public void applyBrakes(int decrement)
        {

            speed = speed - decrement;
        }

        public void printStates()
        {
            Console.WriteLine("speed: " + speed +
                              " gear: " + gear);
        }
    }


    // class implements interface
    class Bike : Vehicle
    {

        int speed;
        int gear;

        // to change gear
        public void changeGear(int newGear)
        {

            gear = newGear;
        }

        // to increase speed
        public void speedUp(int increment)
        {

            speed = speed + increment;
        }

        // to decrease speed
        public void applyBrakes(int decrement)
        {

            speed = speed - decrement;
        }

        public void printStates()
        {
            Console.WriteLine("speed: " + speed +
                              " gear: " + gear);
        }

    }
}
