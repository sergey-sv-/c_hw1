using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqr
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            //label for goto
            label1:

            Console.WriteLine("Enter a:");
            a = Convert.ToInt32(Console.ReadLine());
                if (a==0)
                {
                Console.WriteLine("a can not be 0!!!");
                goto label1;
                }
            Console.WriteLine("Enter b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter с:");
            c = Convert.ToInt32(Console.ReadLine());

            double d;
            d = b * b - 4 * a * c;

            if (d < 0)
            {
                Console.WriteLine("No result, discriminant<0");
            }

            if (d == 0)
            {
                double x1 = -b / (2 * a);
                Console.WriteLine("Discriminant=0, x={0}", x1);
            }

            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(Convert.ToDouble(d))) / (2 * a);
                double x2 = (-b - Math.Sqrt(Convert.ToDouble(d))) / (2 * a);
                Console.WriteLine("Discriminant = {0}, x1 = {1}, x2 = {2}", d, x1, x2);
            }
        }
    }
}
