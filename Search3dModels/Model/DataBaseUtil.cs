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
       public static Boolean addModelToDataBase(string modelName, float modelX, float modelY, float modelZ,bool modelPrivate,byte[] modelfle)
       {
        try{
            if (Utils.getPassword().Length == 0 || Utils.getLogin().Length == 0) {
                MessageBox.Show("Please, log-in in your account or create new in the settings window" , "You need to log-in", MessageBoxButtons.OK);
                return false;
            }
            NpgsqlConnection connection = DataBaseConnect.getConnection();              
            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection=connection;
            command.CommandText = "INSERT INTO models (user_id, model_name, model_x,model_y,model_z,model_private,model_file) VALUES (@user_id, @model_name, @model_x,@model_y,@model_z,@model_private,@model_file);";
            command.Parameters.AddWithValue("@model_name", modelName);
            command.Parameters.AddWithValue("@user_id", getUserIdByLoginAndPassword(Utils.getLogin(), Utils.getPassword()));
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
                MessageBox.Show(e.Message, "getModelFromDataBase()", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        public static Boolean isUserInDb(string login, string password)
        {
            try
            {
                NpgsqlConnection connection = DataBaseConnect.getConnection();               
                connection.Open();            
                string SQL = "SELECT user_id FROM users where user_mail='" + login + "' and user_password='" + password + "';";

                NpgsqlCommand command = new NpgsqlCommand(SQL, connection);
                NpgsqlDataReader dr = command.ExecuteReader();
                connection.Close();

                if (dr.HasRows){
                    return true;
                }else {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "isUserInDb()", MessageBoxButtons.OK);
                return false;
            }
            
        }

        public static int getUserIdByLoginAndPassword(string login, string password)
        {
            try
            {
                NpgsqlConnection connection = DataBaseConnect.getConnection();
                connection.Open();
                string SQL = "SELECT user_id FROM users where user_mail='"+login+"' and user_password='"+password+"';";            
                NpgsqlCommand command = new NpgsqlCommand(SQL, connection);                   
                Int32 count = (Int32)command.ExecuteScalar();           
                connection.Close();                      
                return count;               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "getUserIdByLoginAndPassword()", MessageBoxButtons.OK);
                return 1;
            }

        } 
    }
}
