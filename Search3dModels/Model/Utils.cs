using System;
using System.Collections.Generic;
using System.Linq;

namespace Search3dModels.Model
{
    static class Utils
    {
        public static double getMinValue(params double[] values) {
            return values.Min();
        }
        public static double getMaxValue(params double[] values)
        {
            return values.Max();
        }
    }
}
