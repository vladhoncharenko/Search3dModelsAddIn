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
using Search3dModels.Model;
using Search3dModels.Controller;
using System.Text.RegularExpressions;

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

        private void searchButton_Click(object sender, EventArgs e)
        {
           GetModelsController.SearchModels();
        }

        private void openSelectedButton_Click(object sender, EventArgs e)
        {
            Utils.OpenModelsInSw();
        }

      
      
        private void scaleFactorInput_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]*$");
            MatchCollection matches = regex.Matches(GetModels.scaleFactorInput.Text);
            if (!(matches.Count > 0))
            {
                MessageBox.Show("Please, enter a valid scale factor value!", "Search 3D Models", MessageBoxButtons.OK);
                GetModels.searchButton.Visible = false;
            }
            else
            {
                GetModels.searchButton.Visible = true;
            }
        }

        private void widthInput_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[^\d*\,\d*+]{1,10}$");
            MatchCollection matches = regex.Matches(GetModels.widthInput.Text);
            if (matches.Count > 0)
            {
                MessageBox.Show("Please, enter a valid width value!", "Search 3D Models", MessageBoxButtons.OK);
                GetModels.searchButton.Visible = false;
            }
            else
            {
                GetModels.searchButton.Visible = true;
            }
        }

        private void lengthInput_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[^\d*\,\d*+]{1,10}$");
            MatchCollection matches = regex.Matches(GetModels.lengthInput.Text);
            if (matches.Count > 0)
            {
                MessageBox.Show("Please, enter a valid length value!!", "Search 3D Models", MessageBoxButtons.OK);
                GetModels.searchButton.Visible = false;
            }
            else
            {
                GetModels.searchButton.Visible = true;
            }
        }

        private void heightInput_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[^\d*\,\d*+]{1,10}$");
            MatchCollection matches = regex.Matches(GetModels.heightInput.Text);
            if (matches.Count > 0)
            {
                MessageBox.Show("Please, enter a valid height value!", "Search 3D Models", MessageBoxButtons.OK);
                GetModels.searchButton.Visible = false;
            }
            else
            {
                GetModels.searchButton.Visible = true;
            }
        }


              
    }
}
