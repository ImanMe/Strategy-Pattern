using System.Collections.Generic;

namespace Strategy_Pattern.PatternVersion
{
    public interface IAveragingMethod
    {
        double AverageFor(List<double> values);
    }
}
