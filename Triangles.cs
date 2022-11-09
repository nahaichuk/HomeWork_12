using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12
{
    class Triangle
    {
        
        internal double Footing;
        internal double Side;

        double GetArea()
        {
            double Height = 0;
            Height = Math.Sqrt(Math.Pow(Side, 2) - Math.Pow(Footing, 2));
            return 1/2*Height*Side;
        }
        public void Display()
        {
            Console.WriteLine("Footing: {0}", Footing);
            Console.WriteLine("Side: {0}", Side);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    class ExecuteTriangle
    {
        static void Main(string[] args)
        {
            Triangle r = new Triangle();
            r.Footing = 4.5;
            r.Side = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }
}
