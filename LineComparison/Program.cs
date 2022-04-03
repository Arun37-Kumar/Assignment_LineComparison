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
            LineCompare compare = new LineCompare();
            compare.ComparisonLine(12,30,5,10);
            Console.ReadLine();
        }
    }
}
