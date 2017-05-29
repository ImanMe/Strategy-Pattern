using System.Collections.Generic;

namespace Strategy_Pattern.PatternVersion
{
    public class Calculator
    {
        public double CalculateAverageFor(List<double> values, IAveragingMethod averagingMethod)
        {
            return averagingMethod.AverageFor(values);
        }
    }
}
