using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LineCompare
    {
        public double ComparisonLine(int x1, int x2, int y1,int y2)
        {
            int X = x2 - x1;
            int Y = y2 - y1;
            int Z = X*X - Y*Y;
            double length;

            length = (double)Math.Sqrt(Z);
            //Console.WriteLine("Length : {0}", length);
            return length;
        }
    }
}
