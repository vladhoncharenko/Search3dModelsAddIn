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
                string fileName = model.GetTitle() + ".SLDPRT";
                string sourcePath = model.GetPathName();
                string targetPath;

                if (getModelsFolder() == null) {
                    string myDocuments = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
                    targetPath = myDocuments + @"\Search3DModels\Temp\";
                }
                else {
                    targetPath = getModelsFolder() + @"\Temp\";
                }

                string destinationFile = System.IO.Path.Combine(targetPath, fileName);

                if (!System.IO.Directory.Exists(targetPath)){
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
            catch (Exception exp) {
                MessageBox.Show(exp.Message, "modelToBytes()", MessageBoxButtons.OK);
            }
            return null;
        }

        public static bool bytesToModel(string fileName, byte[] byteArray)
        {
            try{
                System.IO.FileStream fileStream = new System.IO.FileStream
                    (fileName, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                fileStream.Write(byteArray, 0, byteArray.Length);
                fileStream.Close();
                return true;
            }catch (Exception exp){
                MessageBox.Show(exp.Message, "bytesToModel()", MessageBoxButtons.OK);
            }
            return false;
        }

        public static bool ConnectionValidator(string login, string password){
            return DataBaseUtil.isUserInDb(login,password);
        }

        public static bool SaveConnectionProperties(string login, string password)
        {
            SettingsClass.Instance.login = login;
            SettingsClass.Instance.password = password;
            return SettingsClass.Instance.writeSettings();
        }

        public static bool SaveModelsFolder(string modelsPath)
        {
           SettingsClass.Instance.modelsPath = modelsPath;
           return SettingsClass.Instance.writeSettings();
        }

        public static string getModelsFolder()
        {
            SettingsClass.Instance.readSettings();
            return SettingsClass.Instance.modelsPath;
        }
        public static string getLogin()
        {
            SettingsClass.Instance.readSettings();
            return SettingsClass.Instance.login;
        }
        public static string getPassword()
        {
            SettingsClass.Instance.readSettings();
            return SettingsClass.Instance.password;
        }
                            

    }
}
