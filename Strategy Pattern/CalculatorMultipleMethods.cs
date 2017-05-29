using System.Collections.Generic;
using System.Linq;

namespace Strategy_Pattern
{
    public class CalculatorMultipleMethods
    {
        public double CalculateAverageByMean(List<double> values)
        {
            return values.Sum() / values.Count;
        }

        public double CalculateValuesByMedian(List<double> values)
        {
            var sortedValues = values.OrderBy(x => x).ToList();

            if (sortedValues.Count % 2 == 1)
            {
                return sortedValues[(sortedValues.Count - 1) / 2];
            }

            return (sortedValues[(sortedValues.Count / 2) - 1] + sortedValues[sortedValues.Count / 2] / 2);
        }
    }
}
