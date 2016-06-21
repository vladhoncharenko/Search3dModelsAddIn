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

    public partial class GetModels : Form
    {
        ISldWorks swAppGetModels;
        SwAddin getModelsAddin;
        public GetModels(SwAddin addin)
        {
            getModelsAddin = addin;
            swAppGetModels = addin.SwApp;
            InitializeComponent();
        }
        private void MyNewFormGetModels_FormClosed(object sender, FormClosedEventArgs e)
        {
            getModelsAddin.GetModelsForm= null; 
            GC.Collect();
        }
       
        private void openAllbutton_Click(object sender, EventArgs e)
        {

        }

      
      

    }
}
