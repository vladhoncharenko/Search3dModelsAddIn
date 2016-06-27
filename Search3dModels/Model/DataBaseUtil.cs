using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Search3dModels.Model
{
   static class DataBaseUtil
    {
       private static System.Data.DataSet ds = new System.Data.DataSet();
       public static Boolean addModelToDataBase(int userID, string modelName, float modelX, float modelY, float modelZ,bool modelPrivate,byte[] modelfle)
       {
            try{

            NpgsqlConnection connection = DataBaseConnect.getConnection();
            int firstUserId= 1;           
            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection=connection;
            command.CommandText = "INSERT INTO models (user_id, model_name, model_x,model_y,model_z,model_private,model_file) VALUES (@user_id, @model_name, @model_x,@model_y,@model_z,@model_private,@model_file);";
            command.Parameters.AddWithValue("@user_id", firstUserId);
            command.Parameters.AddWithValue("@model_name", modelName);
            command.Parameters.AddWithValue("@model_x", modelX);
            command.Parameters.AddWithValue("@model_y", modelY);
            command.Parameters.AddWithValue("@model_z", modelZ);
            command.Parameters.AddWithValue("@model_private", modelPrivate);
            command.Parameters.AddWithValue("@model_file", modelfle);
            command.ExecuteNonQuery();
           
            connection.Close();
            }
            catch(Exception e){
                Console.WriteLine(e);
                MessageBox.Show(e.Message, "addModelToDataBase()", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        public static Boolean getModelFromDataBase()
        {
            try
            {
                NpgsqlConnection connection = DataBaseConnect.getConnection();
                connection.Open();
                string sql = "";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, connection);
                connection.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        } 


    }
}
