using Npgsql;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Search3dModels.Model
{
    static class Utils
    {
        
        public static double GetMinValue(params double[] values)
        {
            return values.Min();
        }

        public static double GetMaxValue(params double[] values)
        {
            return values.Max();
        }

        public static byte[] ModelToBytes(ModelDoc2 model)
        {
            try
            {
                string fileName = model.GetTitle() + ".SLDPRT";
                                
                if (model.GetPathName() == null || model.GetPathName().Length==0)
                {
                    MessageBox.Show("Please, save model before adding!", "Search 3d Models", MessageBoxButtons.OK);
                    MessageBox.Show("Model in DB will be with with name, that was in 'Model Name' input box!", "Attention!", MessageBoxButtons.OK);
                    bool boolstatus = model.Save3((int)swSaveAsOptions_e.swSaveAsOptions_SaveReferenced, 0, 0);
                                    
                }

                string sourcePath = model.GetPathName();
                               
                string targetPath;

                if (GetModelsFolder() == null || GetModelsFolder().Length == 0)
                {
                    string myDocuments = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
                    targetPath = myDocuments + @"\Search3DModels\Temp\";
                }
                else
                {
                    targetPath = GetModelsFolder() + @"\Temp\";
                }
               
                string destinationFile = System.IO.Path.Combine(targetPath, fileName);               

                if (!System.IO.Directory.Exists(targetPath))
                {
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
            catch (Exception exp)
            {
                MessageBox.Show(exp.StackTrace, "modelToBytes()", MessageBoxButtons.OK);
                
            }
            return null;
        }

        public static string CreateAndSaveModelFromBytesInFolder(string fileName, byte[] byteArray)
        {
            try
            {
                string targetPath;
                string fileNameWithRes = fileName + ".SLDPRT";
                if (GetModelsFolder() == null || GetModelsFolder().Length == 0)
                {
                    string myDocuments = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
                    targetPath = myDocuments + @"\Search3DModels\Models\";
                }
                else
                {
                    targetPath = GetModelsFolder() + @"\Models\";
                }

                string destinationFile = System.IO.Path.Combine(targetPath, fileNameWithRes);

                if (!System.IO.Directory.Exists(targetPath))
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }

                System.IO.FileStream fileStream = new System.IO.FileStream
                    (destinationFile, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                fileStream.Write(byteArray, 0, byteArray.Length);
                
                fileStream.Close();
                return destinationFile;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "createAndSaveModelFromBytesInFolder()", MessageBoxButtons.OK);
                return "";
            }

        }


        public static bool ConnectionValidator(string login, string password)
        {
            return DataBaseUtil.isUserInDb(login, password);
        }

        public static bool SaveConnectionProperties(string login, string password)
        {
            SettingsClass.Instance.login = login;
            SettingsClass.Instance.password = password;
            return SettingsClass.Instance.WriteSettings();
        }

        public static bool SaveModelsFolder(string modelsPath)
        {
            SettingsClass.Instance.modelsPath = modelsPath;
            return SettingsClass.Instance.WriteSettings();
        }

        public static string GetModelsFolder()
        {
            SettingsClass.Instance.ReadSettings();
            return SettingsClass.Instance.modelsPath;
        }
        public static string GetLogin()
        {
            SettingsClass.Instance.ReadSettings();
            return SettingsClass.Instance.login;
        }
        public static string GetPassword()
        {
            SettingsClass.Instance.ReadSettings();
            return SettingsClass.Instance.password;
        }
        public static byte[] ObjectToByteArray(object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }

        }

        public static void OpenModelsInSw()
        {
            int rowindex = GetModels.resultsDataGridView.CurrentCell.RowIndex;
            int modelId = Convert.ToInt32(GetModels.resultsDataGridView.Rows[rowindex].Cells[0].Value.ToString());
            string modelName = GetModels.resultsDataGridView.Rows[rowindex].Cells[1].Value.ToString();            
            string modelDest=Utils.CreateAndSaveModelFromBytesInFolder(modelName, DataBaseUtil.getModelFileById(modelId));            
            SldWorks swApp = Activator.CreateInstance(Type.GetTypeFromProgID("SldWorks.Application")) as SldWorks;
            swApp.Visible = false;
            swApp.OpenDoc6(modelDest, (int)swDocumentTypes_e.swDocPART, (int)swOpenDocOptions_e.swOpenDocOptions_LoadModel, "", 0, 0);
                            
        }

    }
}
