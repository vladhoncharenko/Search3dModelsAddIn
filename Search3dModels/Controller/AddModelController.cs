﻿using Search3dModels.Model;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Search3dModels.Controller
{
    static class AddModelController
    {
        public static void SetModelSizesInForm()
        {
            try
            {

                ModelDoc2 swModel = default(ModelDoc2);
                swModel = (ModelDoc2)AddModel.swAppAddModel.ActiveDoc;
                double[] modelXYZ = SolidWorksUtil.GetModelXYZ((PartDoc)swModel);
                AddModel.nameGetModel.Text = swModel.GetTitle();
                AddModel.heighGetModel.Text = modelXYZ[0].ToString();
                AddModel.lengthGetModel.Text = modelXYZ[1].ToString();
                AddModel.widthGetModel.Text = modelXYZ[2].ToString();



            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "setModelSizesInForm()", MessageBoxButtons.OK);
            }
        }
    

        public static void AddModelToDataBase()
        {
            ModelDoc2 swModel = default(ModelDoc2);
            swModel = (ModelDoc2)AddModel.swAppAddModel.ActiveDoc;

            
            if (DataBaseUtil.AddModelToDataBase(AddModel.nameGetModel.Text, Single.Parse(AddModel.heighGetModel.Text),
                Single.Parse(AddModel.lengthGetModel.Text), Single.Parse(AddModel.widthGetModel.Text), AddModel.privateModelCheckBox.Checked, Utils.ModelToBytes(swModel)))
            {
                MessageBox.Show("Model was added!", "Search 3D Models", MessageBoxButtons.OK);

            }

        }
    }
}
