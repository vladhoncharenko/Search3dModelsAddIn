using Npgsql;
using Search3dModels.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Search3dModels.Controller
{
    static class GetModelsController
    {
        public static void SearchModels()
        {
            if (GetModels.scaleCheckBox.Checked)
            {
                DataBaseUtil.getModelFromDataBaseWithScaleFactor(Convert.ToSingle(GetModels.heightInput.Text),
                    Convert.ToSingle(GetModels.lengthInput.Text), Convert.ToSingle(GetModels.widthInput.Text), Convert.ToSingle(GetModels.scaleFactorInput.Text));
            }
            else
            {
                DataBaseUtil.getModelFromDataBase(Convert.ToSingle(GetModels.heightInput.Text), Convert.ToSingle(GetModels.lengthInput.Text),
                     Convert.ToSingle(GetModels.widthInput.Text));

            }
        }

        public static void SetViewDataGrid(NpgsqlDataReader dr)
        {
            GetModels.resultsDataGridView.DataSource = null;
            DataTable dt = null;
            dt = new DataTable();
            dt.Load(dr);
            GetModels.resultsDataGridView.DataSource = dt;
        }

        
        }
    }

