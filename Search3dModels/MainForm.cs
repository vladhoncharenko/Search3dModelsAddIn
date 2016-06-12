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
    public partial class MainForm : Form
    {

    ISldWorks swApp;  //Переменная Solidworks
    SwAddin myAddin;  //Переменная аддона
    public MainForm(SwAddin addin)
        {

            myAddin = addin;// получаем ссылку на SwAddin  
            swApp = addin.SwApp;// получаем ссылку на SldWorks  
            InitializeComponent();
        }

    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)  
        {  
            //myAddin.MyForm = null; //Обнуляем переменную нашей формы для аддина, чтобы  был возможен последующий запуск.  
          //  GC.Collect();  
        }
        private void button1_Click(object sender, EventArgs e)
        {
            swApp.SendMsgToUser2("Моё сообщение", (int)swMessageBoxIcon_e.swMbInformation, (int)swMessageBoxBtn_e.swMbOk);

        }
    }
}
