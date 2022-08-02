using System;

namespace Geometry
{
   public class program
    {
        private static object converTo;

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Co-ordinates a1,b1,c1)");
            int a1 = Int32.Parse(Console.ReadLine());
            int b1 = Int32.Parse(Console.ReadLine());
            int c1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Co-ordinates  and a2,b2,c3");
            int a2 = Int32.Parse(Console.ReadLine());
            int b2 = Int32.Parse(Console.ReadLine());
            int c2 = Int32.Parse(Console.ReadLine());

            //int line = (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2) * 1.0));
            //Console.WriteLine("Length of a Line " + line);

            if ((a1/a2 == b1/b2) && (a1/a2 == c1/c2) && (b1/b2 == c1/c2))
            {
                Console.WriteLine("The given straight are identical");
            }
            else
            {
                Console.WriteLine("The given straight are not identical");
            }

        }
    }
}