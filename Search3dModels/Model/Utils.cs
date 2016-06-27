using SolidWorks.Interop.sldworks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

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
        public static byte[] modelToBytes(ModelDoc2 model)
        {
            try{
               
                string fileName = model.GetTitle()+".SLDPRT";             
                string sourcePath = model.GetPathName();
                string targetPath = @"C:\TestFolder\SubDir\";
                string destinationFile = System.IO.Path.Combine(targetPath, fileName);   
          
                if (!System.IO.Directory.Exists(targetPath)) {
                    System.IO.Directory.CreateDirectory(targetPath);
                }
                               
                System.IO.File.Copy(sourcePath, destinationFile, true);

                FileStream fs = new FileStream(destinationFile, FileMode.Open, FileAccess.Read);
                byte[] modelInBytes = new byte[fs.Length];
                fs.Read(modelInBytes, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                Directory.Delete(targetPath, true);

                return modelInBytes;
            }
            catch (Exception exp){
                MessageBox.Show(exp.Message, "modelToBytes()", MessageBoxButtons.OK);
            }
            return null;
        }

        public static bool bytesToModel(string fileName, byte[] byteArray) {
            try{                
                System.IO.FileStream fileStream = new System.IO.FileStream
                    (fileName, System.IO.FileMode.Create, System.IO.FileAccess.Write);               
                fileStream.Write(byteArray, 0, byteArray.Length);                
                fileStream.Close();
                return true;
            }
            catch (Exception exp){
                MessageBox.Show(exp.Message, "bytesToModel()", MessageBoxButtons.OK);
            }
            return false;
        }

    }
}
