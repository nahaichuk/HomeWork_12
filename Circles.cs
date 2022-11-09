using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12
{
    internal class Circle
    {
        //member variables
        internal double Radius;
 
        double GetArea()
        {
            return Math.Pow(Radius, 2) * 3.14;
        }
        public void Display()
        {
            Console.WriteLine("Radius: {0}", Radius);
              Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle

    class ExecuteCircle
    {
        static void Main(string[] args)
        {
            Circle r = new Circle();
            r.Radius = 4.5;
            r.Display();
            Console.ReadLine();
        }
    }
}
