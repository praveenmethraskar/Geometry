using System;

namespace Geometry
{
   public class program
    {
        private static object converTo;

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Co-ordinates (x1,y1)");
            int x1 = Int32.Parse(Console.ReadLine());
            int y1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Co-ordinates (x2,y2)");
            int x2 = Int32.Parse(Console.ReadLine());
            int y2 = Int32.Parse(Console.ReadLine());

            int line = (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2) * 1.0));
            Console.WriteLine("Length of a Line " + line);

        }
    }
}