using Search3dModels.Controller;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Search3dModels.Model
{
    class SolidWorksUtils
    {        
        const double MaxDouble = 1.79769313486231E+308;
        const double MinDouble = -1.79769313486231E+308;
        static double X_max;
        static double X_min;
        static double Y_max;
        static double Y_min;
        static double Z_max;
        static double Z_min;
      
        public static double[] GetModelXYZ(PartDoc doc)
        {
            X_max = MinDouble;
            X_min = MaxDouble;
            Y_max = MinDouble;
            Y_min = MaxDouble;
            Z_max = MinDouble;
            Z_min = MaxDouble;

            double[] modelSizes = new double[3];
            Double[] BoxFeatureDblArray = (Double[])(doc).GetPartBox(true);

            X_max = Utils.getMaxValue(BoxFeatureDblArray[0], BoxFeatureDblArray[3], X_max);
            X_min = Utils.getMinValue(BoxFeatureDblArray[0], BoxFeatureDblArray[3], X_min);
            Y_max = Utils.getMaxValue(BoxFeatureDblArray[1], BoxFeatureDblArray[4], Y_max);
            Y_min = Utils.getMinValue(BoxFeatureDblArray[1], BoxFeatureDblArray[4], Y_min);
            Z_max = Utils.getMaxValue(BoxFeatureDblArray[2], BoxFeatureDblArray[5], Z_max);
            Z_min = Utils.getMinValue(BoxFeatureDblArray[2], BoxFeatureDblArray[5], Z_min);
          
            modelSizes[0] = Math.Round(Math.Abs(X_max - X_min), 3);
            modelSizes[1] = Math.Round(Math.Abs(Y_max - Y_min), 3);
            modelSizes[2] = Math.Round(Math.Abs(Z_max - Z_min), 3);

            Array.Sort(modelSizes);
            Array.Reverse(modelSizes);
            return modelSizes;
        }
    }
}
