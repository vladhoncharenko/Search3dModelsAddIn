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
    public partial class AddModel : Form
    {

    ISldWorks swAppAddModel;
    SwAddin addModelAddin; 

    public AddModel(SwAddin addin)
        {
            addModelAddin = addin;
            swAppAddModel = addin.SwApp;
            InitializeComponent();
        }

    private void AddModelForm_FormClosed(object sender, FormClosedEventArgs e)  
        {
        
          addModelAddin.AddModelForm = null;          
          GC.Collect();
          
        }
    private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AddModelsFromFolder addModelsFromFolderForm = new AddModelsFromFolder();       
                addModelsFromFolderForm.Show();

            }
            catch
            {

            }

        }

    private void AddModel_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click_1(object sender, EventArgs e)
    {

    }
    }
}
