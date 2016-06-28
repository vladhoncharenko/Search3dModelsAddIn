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

namespace Search3dModels
{
    public partial class ConnectionSettings : Form
    {
        static ISldWorks swConnectionSettingsApp;
        static SwAddin connectionSettingsAddin; 
        public ConnectionSettings(SwAddin addin)
        {
            connectionSettingsAddin = addin;
            swConnectionSettingsApp = addin.SwApp;
            InitializeComponent();
        }
        private void ConnectionSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            connectionSettingsAddin.ConnectionSettingsForm = null; 
            GC.Collect();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (ConnectionSettingsController.validateAndSaveLoginPAssword()) {
                MessageBox.Show("Your account is connected!", "Success", MessageBoxButtons.OK);
            };     
        }

        private void selectFolderToSaveModels_Click(object sender, EventArgs e)
        {
            ConnectionSettingsController.selectFolder();          
        }

        private void ConnectionSettings_Load(object sender, EventArgs e)
        {
            ConnectionSettingsController.onLoad();         
        }

       
    }
}
