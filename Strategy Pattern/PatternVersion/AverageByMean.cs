using System.Collections.Generic;
using System.Linq;

namespace Strategy_Pattern.PatternVersion
{
    public class AverageByMean : IAveragingMethod
    {
        public double AverageFor(List<double> values)
        {
            return values.Sum() / values.Count;
        }


    }
}
