using System;

namespace Geometry
{
   public class program
    {
        private static object converTo;

        public static void Main(string[] args)
        {


            Console.WriteLine("Enter Co-ordinates a1,b1,c1,d1 and a2,b2,c3,d2");

            //int line = (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2) * 1.0));
            //Console.WriteLine("Length of a Line " + line);
            Linecomparision linecomparision = new Linecomparision();
            linecomparision.Line_comparision();
            linecomparision.Display();

            



        }
    }
}