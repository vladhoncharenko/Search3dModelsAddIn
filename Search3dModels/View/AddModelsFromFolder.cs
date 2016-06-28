using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.IO;
using Search3dModels.Controller;

namespace Search3dModels
{
    public partial class AddModelsFromFolder : Form
    {

        public static ISldWorks swAddModelsFromFolderApp;
        public static SwAddin addModelsFromFolderAddin;  
public AddModelsFromFolder(SwAddin addin)
{
    addModelsFromFolderAddin = addin; 
    swAddModelsFromFolderApp = addin.SwApp;
    InitializeComponent();
}
public AddModelsFromFolder()
{
    
    InitializeComponent();
}


private void MyNewForm_FormClosed(object sender, FormClosedEventArgs e)
{
    addModelsFromFolderAddin.AddModelsFromFolder = null; 
    GC.Collect();
}
        private void button1_Click(object sender, EventArgs e)
        {
            AddModelsFromFolderController.addSelectedModelstoDb(AddModelsFromFolder.modelsFromFolderLB);
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddModelsFromFolderController.getModelsFromFolder();        
        }

        private void addAllutton_Click(object sender, EventArgs e)
        {
            AddModelsFromFolderController.addAllModelstoDb(AddModelsFromFolder.modelsFromFolderLB);
            this.Close();
            
        }
     
                     
    }
}
