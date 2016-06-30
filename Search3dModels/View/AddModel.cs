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
using Search3dModels.Controller;
using System.Text.RegularExpressions;

namespace Search3dModels
{
    public partial class AddModel : Form
    {

    public static ISldWorks swAppAddModel;
    public static SwAddin addModelAddin;
    public static SldWorks swApp;

    
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
            try{   
                AddModelsFromFolder addModelsFromFolderForm = new AddModelsFromFolder();       
                addModelsFromFolderForm.Show();
            }
            catch{

            }
            this.Close();

        }

    private void AddModel_Load(object sender, EventArgs e)
    {
        AddModelController.SetModelSizesInForm();
        
       
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        AddModelController.AddModelToDataBase();
        this.Close();
    }

   
    

    private void heighGetModel_TextChanged(object sender, EventArgs e)
    {
        Regex regex = new Regex(@"[^\d*\,\d*+]{1,10}$");
        MatchCollection matches = regex.Matches(AddModel.heighGetModel.Text);
        if (matches.Count > 0)
        {
            MessageBox.Show("Please, enter a valid height value!", "Search 3D Models", MessageBoxButtons.OK);
            AddModel.AddModelButton.Visible = false;
        }
        else
        {
            AddModel.AddModelButton.Visible = true;
        }
    }

    private void lengthGetModel_TextChanged(object sender, EventArgs e)
    {
        Regex regex = new Regex(@"[^\d*\,\d*+]{1,10}$");
        MatchCollection matches = regex.Matches(AddModel.lengthGetModel.Text);
        if (matches.Count > 0)
        {
            MessageBox.Show("Please, enter a valid length value!!", "Search 3D Models", MessageBoxButtons.OK);
            AddModel.AddModelButton.Visible = false;
        }
        else
        {
            AddModel.AddModelButton.Visible = true;
        }
    }

    private void widthGetModel_TextChanged(object sender, EventArgs e)
    {
        Regex regex = new Regex(@"[^\d*\,\d*+]{1,10}$");
        MatchCollection matches = regex.Matches(AddModel.widthGetModel.Text);
        if (matches.Count > 0)
        {
            MessageBox.Show("Please, enter a valid width value!", "Search 3D Models", MessageBoxButtons.OK);
            AddModel.AddModelButton.Visible = false;
        }
        else {
            AddModel.AddModelButton.Visible = true;
        }
    }

    private void nameGetModel_TextChanged(object sender, EventArgs e)
    {
        Regex regex = new Regex(@"^[^<>#@$%^&+*]$");
        MatchCollection matches = regex.Matches(AddModel.nameGetModel.Text);
        if (matches.Count > 0)
        {
            MessageBox.Show("Please, enter a valid name value!", "Search 3D Models", MessageBoxButtons.OK);
            AddModel.AddModelButton.Visible = false;
        }
        else
        {
            AddModel.AddModelButton.Visible = true;
        }
    }


    
}
}