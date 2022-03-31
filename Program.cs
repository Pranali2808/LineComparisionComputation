using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            LineComparision lineComparison = new LineComparision();
            lineComparison.PointValues();
            double lineLength = lineComparison.GetLength();
            Console.WriteLine("Length of first Line according to points is= " + lineLength);
            Console.ReadLine();
        }
    }
}
