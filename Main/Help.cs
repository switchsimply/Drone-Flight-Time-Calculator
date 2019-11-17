using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drone_Calculations
{
    class HelpLibrary
    {
        public DataTable ExecuteSqlQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                string connetionString = @"Server= localhost; Database= DroneCalculations; Integrated Security=True;";
                SqlConnection cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, connetionString);
                da.Fill(dt);
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable ExecuteStoredProcedure(string procName, List<SqlParameter> spParams)
        {
            string connetionString = @"Server= localhost; Database= DroneCalculations; Integrated Security=True;";
            DataTable dt = new DataTable();
            try
            {

                SqlConnection cnn = new SqlConnection(connetionString);
                SqlCommand sql_command;
                sql_command = new SqlCommand(procName, cnn);
                sql_command.CommandType = CommandType.StoredProcedure;
                if (spParams != null && spParams.Count > 0)
                {
                    sql_command.Parameters.AddRange(spParams.ToArray());
                    SqlDataAdapter da = new SqlDataAdapter(sql_command);
                    da.Fill(dt);
                    sql_command.Parameters.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
    }
}
