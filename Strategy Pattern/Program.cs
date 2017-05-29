using Strategy_Pattern.PatternVersion;
using System;
using System.Collections.Generic;

namespace Strategy_Pattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            var values = new List<double> { 12, 15, 17, 18 };

            var calculator = new Calculator();

            var averageByMean = calculator.CalculateAverageFor(values, new AverageByMean());

            var averageByMedian = calculator.CalculateAverageFor(values, new AverageByMedian());

            Console.WriteLine(averageByMean);
            Console.WriteLine(averageByMedian);
        }
    }
}
