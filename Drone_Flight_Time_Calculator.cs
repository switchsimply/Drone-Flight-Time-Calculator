using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drone_Flight_Time_Calculator
{
    public partial class Drone_Flight_Time_Calculator : Form
    {
        public Drone_Flight_Time_Calculator()
        {
            InitializeComponent();
            PopulateCmbDroneType();
            PopulateDgvPartDetails();
        }
        private void PopulateDgvPartDetails()
        {
            string query = string.Format("SELECT * FROM DronePartsDetails");
            DataTable dt = ExecuteSqlQuery(query);
            dgvParts_Details.DataSource = dt;
            dgvParts_Details.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParts_Details.RowsDefaultCellStyle.BackColor = Color.White;
            this.dgvParts_Details.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            this.dgvParts_Details.AllowUserToAddRows = true;
            this.dgvParts_Details.Columns[5].ReadOnly = true;
            //this.dgvParts_Details.EditMode = DataGridViewEditMode.EditOnKeystroke;
        }
        private void PopulateCmbDroneType()
        {
            string query = string.Format("Select DroneType from TypeofDrones");
            DataTable dt = ExecuteSqlQuery(query);
            cmbDroneType.DataSource = dt;
            cmbDroneType.DisplayMember = "DroneType";
            cmbDroneType.ValueMember = "DroneType";
            cmbDroneType.SelectedIndex = -1;
        }
        private void CmbDroneType_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbTricopter.Visible = false;
            gbAerodynamic_Forces.Visible = false;
            if (cmbDroneType.SelectedIndex != -1)
            {
                string obj = cmbDroneType.SelectedValue.ToString();
                if (obj == "Tricopter")
                {
                    gbTricopter.Visible = true;
                    //gbTricopter.Enabled=true;
                }
                else if (obj == "RC Plane")
                {
                    gbAerodynamic_Forces.Visible = true;
                }
            }
        }

        private DataTable ExecuteSqlQuery(string query)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        private DataTable ExecuteStoredProcedure(string procName, List<SqlParameter> spParams)
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
        private void BtnUpdate_Click(object sender, EventArgs e)

        {
            try
            {
                UseWaitCursor = true;
                string part = string.Empty;
                string model = string.Empty;
                int specs = 0;
                int qty = 0;
                int unitwgt = 0;
                int wgt = 0;

                if (dgvParts_Details != null && dgvParts_Details.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvParts_Details.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            List<SqlParameter> spParams = new List<SqlParameter>();
                            part = row.Cells[0].Value.ToString();
                            //model = row.Cells[1].Value.ToString();
                            specs = int.Parse(row.Cells[2].Value.ToString());
                            qty = int.Parse(row.Cells[3].Value.ToString());
                            unitwgt = int.Parse(row.Cells[4].Value.ToString());  
                            wgt = int.Parse(row.Cells[5].Value.ToString());
                            spParams.Add(new SqlParameter("@Part", part));
                            //spParams.Add(new SqlParameter("@Model", model));
                            spParams.Add(new SqlParameter("@Specs", specs));
                            spParams.Add(new SqlParameter("@Quantity", qty));
                            spParams.Add(new SqlParameter("@UnitWeight", unitwgt));
                            spParams.Add(new SqlParameter("@Weight", wgt));
                            DataTable dt = ExecuteStoredProcedure("spUpdateDroneInputs", spParams);
                        }
                    }
                }
                PopulateDgvPartDetails();
                MessageBox.Show("Grid Updated Successfully");
                UseWaitCursor = false;
            }
            catch (Exception ex)
            {
                UseWaitCursor = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvParts_Details_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                UseWaitCursor = true;
                string part = string.Empty;
                string model = string.Empty;
                int specs = 0;
                int qty = 0;
                int unitwgt = 0;
                int wgt = 0;
                SqlParameter totalweight = new SqlParameter("@TotalWeight", SqlDbType.VarChar, 30);
                totalweight.Direction = ParameterDirection.Output;
                if (dgvParts_Details != null && dgvParts_Details.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvParts_Details.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            List<SqlParameter> spParams = new List<SqlParameter>();
                            part = row.Cells[0].Value.ToString();
                            //model = row.Cells[1].Value.ToString();
                            specs = int.Parse(row.Cells[2].Value.ToString());
                            qty = int.Parse(row.Cells[3].Value.ToString());
                            unitwgt = int.Parse(row.Cells[4].Value.ToString());
                            wgt = int.Parse(row.Cells[5].Value.ToString());                          
                            spParams.Add(new SqlParameter("@Part", part));
                            //spParams.Add(new SqlParameter("@Model", model));
                            spParams.Add(new SqlParameter("@Specs", specs));
                            spParams.Add(new SqlParameter("@Quantity", qty));
                            spParams.Add(new SqlParameter("@UnitWeight", unitwgt));
                            spParams.Add(new SqlParameter("@Weight", wgt));
                            spParams.Add(totalweight);
                            DataTable dt = ExecuteStoredProcedure("spUpdateDroneInputs", spParams);
                        }
                    }
                }
                PopulateDgvPartDetails();
                lblCalculatedWeight.Text = totalweight.Value.ToString();
                lblTotalWeight.Visible = true;
                lblCalculatedWeight.Visible = true;
                UseWaitCursor = false;
            }
            catch (Exception ex)
            {
                UseWaitCursor = false;
                MessageBox.Show(ex.Message);
            }
        }
    }
}

