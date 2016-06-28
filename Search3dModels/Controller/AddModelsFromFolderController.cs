using Search3dModels.Model;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Search3dModels.Controller
{
    public static class AddModelsFromFolderController
    {
             
        static int fileerror;
        static string[] fileEntries = null;

        public static void getModelsFromFolder() {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select folder with models";
            fbd.ShowNewFolderButton = false;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                AddModelsFromFolder.selectedPath.Text = fbd.SelectedPath;
            }

            ProcessDirectory(AddModelsFromFolder.selectedPath.Text);   
        }
        public static void ProcessDirectory(string targetDirectory)
        {

            fileEntries = Directory.GetFiles(targetDirectory, "*.SLDPRT");
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }


        public static void ProcessFile(string modelPath)
        {
            AddModelsFromFolder.modelsFromFolderLB.Items.Add(modelPath);
        }
        public static void addAllModelstoDb(ListBox listBox)
        {
            List<string> modelsPaths = new List<string>();
            foreach (String modelPath in listBox.Items){
                    modelsPaths.Add(modelPath);
            }
            addModelsFromFolder(modelsPaths);        
       }

        public static void addSelectedModelstoDb(ListBox listBox)
        {
            List<string> modelsPaths = new List<string>();
            foreach (string modelPath in listBox.SelectedItems)
            {
                modelsPaths.Add(modelPath);
            }
            addModelsFromFolder(modelsPaths);
        }

        public static void addModelsFromFolder(List<string> modelsPaths)
        {
            try{
                foreach (string modelPath in modelsPaths){
                                       
                    SldWorks swApp = Activator.CreateInstance(Type.GetTypeFromProgID("SldWorks.Application")) as SldWorks;
                    swApp.Visible = false;
                    swApp.OpenDocSilent(modelPath, (int)swDocumentTypes_e.swDocPART, ref fileerror);
                   
                    ModelDoc2 swModel;
                    swModel = swApp.ActiveDoc;
                    if (swModel != null)
                        swModel.Visible = false;

                    double[] modelXYZ = SolidWorksUtil.GetModelXYZ((PartDoc)swModel);

                    DataBaseUtil.addModelToDataBase(swModel.GetTitle(), Convert.ToSingle(modelXYZ[0]), Convert.ToSingle(modelXYZ[1]), Convert.ToSingle(modelXYZ[2]),
                        AddModelsFromFolder.privateModelCheckBox.Checked, Utils.modelToBytes(swModel));

                    swApp.CloseDoc(swModel.GetTitle()); 
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message, "addModelsFromFolder()", MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show("Models were added!", "Search 3D Models", MessageBoxButtons.OK);
          
            
        }

    }
}
