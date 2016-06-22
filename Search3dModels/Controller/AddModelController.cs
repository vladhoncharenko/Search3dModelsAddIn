using Search3dModels.Model;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Search3dModels.Controller
{
    static class AddModelController
    {
       public static string filename;

       public static void setModelSizesInForm()
        {
            try
            {
                ModelDoc2 swModel = default(ModelDoc2);        
                swModel = (ModelDoc2)AddModel.swAppAddModel.ActiveDoc;                
                double[] modelXYZ = SolidWorksUtils.GetModelXYZ((PartDoc)swModel);
                AddModel.nameGetModel.Text = swModel.GetTitle();
                AddModel.heighGetModel.Text = modelXYZ[0].ToString();
                AddModel.lengthGetModel.Text = modelXYZ[1].ToString();
                AddModel.widthGetModel.Text = modelXYZ[2].ToString();
            }
            catch (Exception e)
            {
                
            }
        }
    }
}
