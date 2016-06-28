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

namespace Search3dModels
{
    public partial class AddModelsFromFolder : Form
    {

        ISldWorks swAddModelsFromFolderApp; 
        SwAddin addModelsFromFolderAddin;  
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
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select folder with models";
            fbd.ShowNewFolderButton = false;           
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                selectedPath.Text = fbd.SelectedPath;
            }
        }

        private void AddModelsFromFolder_Load(object sender, EventArgs e)
        {

        }

        

       
    }
}
