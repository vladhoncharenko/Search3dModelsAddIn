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
    public partial class ConnectionSettings : Form
    {
        ISldWorks swConnectionSettingsApp; 
        SwAddin connectionSettingsAddin; 
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
            swConnectionSettingsApp.SendMsgToUser2("Моё сообщение 3", (int)swMessageBoxIcon_e.swMbInformation, (int)swMessageBoxBtn_e.swMbOk);
        }
    }
}
