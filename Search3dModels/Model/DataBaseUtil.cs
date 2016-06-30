using Npgsql;
using Search3dModels.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Search3dModels.Model
{
    static class DataBaseUtil
    {
        private static System.Data.DataSet ds = new System.Data.DataSet();

        public static Boolean AddModelToDataBase(string modelName, float modelX, float modelY, float modelZ, bool modelPrivate, byte[] modelfle)
        {
            try
            {
                if (Utils.GetPassword().Length == 0 || Utils.GetLogin().Length == 0)
                {
                    MessageBox.Show("Please, log-in in your account or create new in the settings window", "You need to log-in", MessageBoxButtons.OK);
                    return false;
                }
                NpgsqlConnection connection = DataBaseConnect.GetConnection();
                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO models (user_id, model_name, model_x,model_y,model_z,model_private,model_file) VALUES (@user_id, @model_name, @model_x,@model_y,@model_z,@model_private,@model_file);";
                command.Parameters.AddWithValue("@user_id", getUserIdByLoginAndPassword(Utils.GetLogin(), Utils.GetPassword()));
                command.Parameters.AddWithValue("@model_name", modelName);
                command.Parameters.AddWithValue("@model_x", modelX);
                command.Parameters.AddWithValue("@model_y", modelY);
                command.Parameters.AddWithValue("@model_z", modelZ);
                command.Parameters.AddWithValue("@model_private", modelPrivate);
                command.Parameters.AddWithValue("@model_file", modelfle);

                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "addModelToDataBase()", MessageBoxButtons.OK);
                return false;
            }

        }

        public static void getModelFromDataBase(float modelX, float modelY, float modelZ)
        {
            try
            {
                NpgsqlConnection connection = DataBaseConnect.GetConnection();
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;

                if (GetModels.allModelsCheckBox.Checked)
                {
                    command.CommandText = "select model_id,model_name,model_x,model_y,model_z from models where model_x=@model_x and model_y=@model_y and model_z=@model_z and(model_private is not true or user_id=@user_id);";

                }
                else
                {
                    command.CommandText = "select model_id,model_name,model_x,model_y,model_z from models where model_x=@model_x and model_y=@model_y and model_z=@model_z and user_id=@user_id;";
                }

                command.Parameters.AddWithValue("@user_id", getUserIdByLoginAndPassword(Utils.GetLogin(), Utils.GetPassword()));
                command.Parameters.AddWithValue("@model_x", modelX);
                command.Parameters.AddWithValue("@model_y", modelY);
                command.Parameters.AddWithValue("@model_z", modelZ);

                NpgsqlDataReader dr = command.ExecuteReader();

                if (dr.HasRows)
                {
                    //TODO: Make getModelFromDataBase() returns NpgsqlDataReader, and use this method with result  
                    GetModelsController.SetViewDataGrid(dr);

                }
                else
                {
                    MessageBox.Show("There is no models with this paremeters!", "Try other params", MessageBoxButtons.OK);
                }

                connection.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "getModelFromDataBase()", MessageBoxButtons.OK);

            }

        }
        public static void getModelFromDataBaseWithScaleFactor(float modelX, float modelY, float modelZ, float scaleFactor)
        {
            try
            {
                NpgsqlConnection connection = DataBaseConnect.GetConnection();
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connection;


                if (GetModels.allModelsCheckBox.Checked)
                {
                    command.CommandText = "select model_id,model_name,model_x,model_y,model_z from models where model_x>@minModel_x and model_x<@maxModel_x and" +
                    " model_y>@minModel_y and model_y<@maxModel_y and model_z>@minModel_z and model_z<@maxModel_z and (model_private is not true or user_id=@user_id);";

                }
                else
                {
                    command.CommandText = "select model_id,model_name,model_x,model_y,model_z from models where model_x>@minModel_x and model_x<@maxModel_x and" +
                    " model_y>@minModel_y and model_y<@maxModel_y and model_z>@minModel_z and model_z<@maxModel_z and user_id=@user_id;";
                }

                command.Parameters.AddWithValue("@user_id", getUserIdByLoginAndPassword(Utils.GetLogin(), Utils.GetPassword()));
                command.Parameters.AddWithValue("@model_x", modelX);
                command.Parameters.AddWithValue("@model_y", modelY);
                command.Parameters.AddWithValue("@model_z", modelZ);

                command.Parameters.AddWithValue("@minModel_x", modelX - modelX * scaleFactor / 100);
                command.Parameters.AddWithValue("@minModel_y", modelY - modelY * scaleFactor / 100);
                command.Parameters.AddWithValue("@minModel_z", modelZ - modelZ * scaleFactor / 100);

                command.Parameters.AddWithValue("@maxModel_x", modelX + modelX * scaleFactor / 100);
                command.Parameters.AddWithValue("@maxModel_y", modelY + modelY * scaleFactor / 100);
                command.Parameters.AddWithValue("@maxModel_z", modelZ + modelZ * scaleFactor / 100);

                NpgsqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {   //TODO: Make getModelFromDataBaseWithScaleFactor() returns NpgsqlDataReader, and use this method with result
                    GetModelsController.SetViewDataGrid(dr);
                }
                else
                {
                    MessageBox.Show("There is no models with this paremeters!", "Try other params", MessageBoxButtons.OK);
                }

                connection.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "getModelFromDataBase()", MessageBoxButtons.OK);

            }

        }

        public static Boolean isUserInDb(string login, string password)
        {
            try
            {
                NpgsqlConnection connection = DataBaseConnect.GetConnection();
                connection.Open();

                //TODO: Parameterize! Important!
                string SQL = "SELECT user_id FROM users where user_mail='" + login + "' and user_password='" + password + "';";

                NpgsqlCommand command = new NpgsqlCommand(SQL, connection);
                NpgsqlDataReader dr = command.ExecuteReader();
                connection.Close();

                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
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
                NpgsqlConnection connection = DataBaseConnect.GetConnection();
                connection.Open();

                //TODO: Parameterize! Important!
                string SQL = "SELECT user_id FROM users where user_mail='" + login + "' and user_password='" + password + "';";
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

        public static byte[] getModelFileById(int id)
        {
            try
            {
                NpgsqlConnection connection = DataBaseConnect.GetConnection();
                connection.Open();

                //TODO: Parameterize! Important!
                string SQL = "SELECT model_file FROM models where model_id='" + id + "';";
                NpgsqlCommand command = new NpgsqlCommand(SQL, connection);

                NpgsqlDataReader reader = command.ExecuteReader();
                byte[] dr = null;
                                
                    while (reader.Read())
                    {
                        dr = (byte[])reader[0];

                    }
                             
                connection.Close();

                return dr;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "getModelFileById()", MessageBoxButtons.OK);
                return new byte[1];
            }

        }
    }
}
