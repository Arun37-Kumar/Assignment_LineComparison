using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem.");

            // Inputs
            Console.Write("Enter x1 :");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter x2 :");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y1 :");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y2 :");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.Write("Enter a1 :");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a2 :");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b1 :");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b2 :");
            int b2 = Convert.ToInt32(Console.ReadLine());



            LineCompare compare1 = new LineCompare();
            LineCompare compare2 = new LineCompare();
            double firstLine = compare1.ComparisonLine(x1,x2,y1,y2);
            double secondLine = compare2.ComparisonLine(a1,a2,b1,b2);
            compareTo(firstLine,secondLine);
            Console.ReadLine();
        }
        public static void compareTo(double firstLine, double secondLine)
        {
            if (firstLine > secondLine)
            {
                Console.WriteLine("First line is greater.");
            }else if (secondLine > firstLine)
            {
                Console.WriteLine("Second line is greater.");
            }
            else
            {
                Console.WriteLine("Both lines are equal.");
            }
        }
    }
}
