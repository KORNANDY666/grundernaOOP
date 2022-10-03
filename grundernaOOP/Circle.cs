using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grundernaOOP
{
    internal class Circle
    {
        // Creates variables to do calculations with.
        float pi = 3.141f;
        int radius;



        // creates a constructor to take the value of the radius
        public Circle(int Radius)
        {
          radius = Radius;
           
        }


        // 2 methods to calculate 
        public void getArea()
        {
            Console.WriteLine(radius * radius * pi ); 
           
        }
        public void getVolume()
        {
            Console.WriteLine((4 * pi * radius * radius * radius) /3);
        }
    }
}
