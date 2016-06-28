﻿using Search3dModels.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Search3dModels.Controller
{
   static class ConnectionSettingsController
    {
       public static bool validateAndSaveLoginPAssword() {

           if (Utils.ConnectionValidator(ConnectionSettings.loginInput.Text, ConnectionSettings.passwordInput.Text)){
               return Utils.SaveConnectionProperties(ConnectionSettings.loginInput.Text, ConnectionSettings.passwordInput.Text);
           }else{
               MessageBox.Show("Login or password is not valid, please enter correct data, or create new account", "Invalid data!", MessageBoxButtons.OK);
               return false;
           }      
       }

       public static bool selectFolder()
       {
         FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select folder with models";
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == DialogResult.OK){
                ConnectionSettings.selectedFolderForModels.Text = fbd.SelectedPath;
                return Utils.SaveModelsFolder(ConnectionSettings.selectedFolderForModels.Text);
            }else {
                return false;
            }          
       }
       public static void onLoad()
       {
           if (Utils.getModelsFolder().Length==0){
               string myDocuments = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
               ConnectionSettings.selectedFolderForModels.Text = myDocuments + @"\Search3DModels\Models\";
           }else{
              ConnectionSettings.selectedFolderForModels.Text = Utils.getModelsFolder();
           }  
           ConnectionSettings.loginInput.Text=Utils.getLogin();
           ConnectionSettings.passwordInput.Text = Utils.getPassword();
       }
    }
}
