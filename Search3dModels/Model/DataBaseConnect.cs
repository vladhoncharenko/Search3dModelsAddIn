using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Search3dModels.Model
{
    class DataBaseConnect
    {
        public static NpgsqlConnection getConnection() {
            NpgsqlConnection connection = null;
            try
            {
                string connstring = String.Format("Server=31.131.25.44; Port=5432; User Id=postgres; Password=password; Database=postgres;");
                connection = new NpgsqlConnection(connstring);

                }catch(Exception e){
                Console.WriteLine(e);
                MessageBox.Show(e.Message, "getConnection()", MessageBoxButtons.OK);
            }
             return connection;
        }
    }
}
