using System;

namespace Geometry
{
   public class program
    {
        private static object converTo;

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Co-ordinates a1,b1,c1,d1 and a2,b2,c3,d2");
            int a1 = Int32.Parse(Console.ReadLine());            
            int b1 = Int32.Parse(Console.ReadLine());
            int c1 = Int32.Parse(Console.ReadLine());
            int d1 = Int32.Parse(Console.ReadLine());
             
            int a2 = Int32.Parse(Console.ReadLine());
            int b2 = Int32.Parse(Console.ReadLine());
            int c2 = Int32.Parse(Console.ReadLine());
            int d2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("a1="+a1);
            Console.WriteLine("a2="+a2); 
            Console.WriteLine("b1="+b1); 
            Console.WriteLine("b2="+b2);
            Console.WriteLine("c1="+c1);
            Console.WriteLine("c2="+c2);
            Console.WriteLine("d1="+d1);
            Console.WriteLine("d2="+d2);


            //int line = (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2) * 1.0));
            //Console.WriteLine("Length of a Line " + line);

            int line1 = (int)Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));
            int line2 = (int)Math.Sqrt(Math.Pow(c2 - c1,2) + Math.Pow(d2 - d1, 2));

            if (line1 < line2)
            {
                Console.WriteLine("The line2 is greate");
            }
            else if (line1 > line2)
            {
                Console.WriteLine("The line1 is greater");
            }
            else
            {
                Console.WriteLine("The lines are equal");
            }

        }
    }
}