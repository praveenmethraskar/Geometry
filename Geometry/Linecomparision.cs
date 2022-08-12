using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Linecomparision
    {
        int a1 = Int32.Parse(Console.ReadLine());
        int b1 = Int32.Parse(Console.ReadLine());
        int c1 = Int32.Parse(Console.ReadLine());
        int d1 = Int32.Parse(Console.ReadLine());

        int a2 = Int32.Parse(Console.ReadLine());
        int b2 = Int32.Parse(Console.ReadLine());
        int c2 = Int32.Parse(Console.ReadLine());
        int d2 = Int32.Parse(Console.ReadLine());

        public void Line_comparision()
        { 

            Console.WriteLine("a1="+a1);
            Console.WriteLine("a2="+a2);
            Console.WriteLine("b1="+b1);
            Console.WriteLine("b2="+b2);
            Console.WriteLine("c1="+c1);
            Console.WriteLine("c2="+c2);
            Console.WriteLine("d1="+d1);
            Console.WriteLine("d2="+d2);
             
        }

        public void Display()
        {

            int line1 = (int)Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));
            int line2 = (int)Math.Sqrt(Math.Pow(c2 - c1, 2) + Math.Pow(d2 - d1, 2));

            if (line1<line2)
            {
                Console.WriteLine("The line2 is greater");
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
