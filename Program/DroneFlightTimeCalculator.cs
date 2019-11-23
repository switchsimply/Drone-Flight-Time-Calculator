using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drone_Calculations
{
    public partial class DroneFlightTimeCalculator : Form
    {
        public DroneFlightTimeCalculator()
        {
            InitializeComponent();
            populatecmbComponents();
            populateTblPartDetails();
        }
        TableLayoutPanel tblPart_Details = new TableLayoutPanel();
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
            catch (Exception ex)
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

        private void populatecmbComponents()
        {
            string query = string.Format("Select Component from ComponentList");
            DataTable dt = ExecuteSqlQuery(query);
            cmbComponents.DataSource = dt;
            cmbComponents.DisplayMember = "Component";
            cmbComponents.ValueMember = "Component";
            cmbComponents.SelectedIndex = -1;
        }

        private void btnAddNewPart_Click(object sender, EventArgs e)
        {
            tblPart_Details.Visible = true;
            FilltblPartDetails();
            tblPart_Details.RowCount++;
        }
        private void populateTblPartDetails()
        {
            tblPart_Details.Size = new Size(705, 200);
            tblPart_Details.Dock = DockStyle.Right;
            tblPart_Details.AutoScroll = true;
            tblPart_Details.AutoSize = true;
            //tblPart_Details.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            //tblPart_Details.BackColor = Color.Wheat;
            tblPart_Details.TabIndex = 1;
            tblPart_Details.ColumnCount = 5;
            tblPart_Details.RowCount = 2;
            tblPart_Details.Visible = false;
            tblPart_Details.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tblPart_Details.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblPart_Details.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblPart_Details.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblPart_Details.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblPart_Details.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblPart_Details.Controls.Add(new Label() { Text = "Part Name" }, 0, 0);
            tblPart_Details.Controls.Add(new Label() { Text = "Specifications" }, 1, 0);
            tblPart_Details.Controls.Add(new Label() { Text = "Quantity" }, 2, 0);
            tblPart_Details.Controls.Add(new Label() { Text = "Unit Weight" }, 3, 0);
            tblPart_Details.Controls.Add(new Label() { Text = "Weight" }, 4, 0);
            Controls.Add(tblPart_Details);
        }

        TextBox tbQty = new TextBox();
        private void FilltblPartDetails()
        {
            try
            { 
                int rowCount;
                int columnCount;
                columnCount = tblPart_Details.ColumnCount;
                rowCount = tblPart_Details.RowCount;
                TextBox tbUnitWeight = new TextBox();

                if (cmbComponents.SelectedIndex != -1)
                {
                    string ComponentName = cmbComponents.SelectedValue.ToString();
                    string query = string.Format("select * from ComponentList where Component = '{0}'", ComponentName);
                    DataTable dt = ExecuteSqlQuery(query);
                    for (int x = 0; x < columnCount; x++)
                    {
                        //tblPart_Details.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                        switch (x)
                        {
                            case 0:
                                {    
                                    Label lblPartName = new Label() { Text = ComponentName };
                                    lblPartName.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                                    tblPart_Details.Controls.Add(lblPartName, x, rowCount);
                                    break;
                                }
                            case 1:
                                {
                                    //string qry = string.Format("select Specifications from ComponentList where Component = {0}", ComponentName);
                                    //DataTable dtSpecifications = ExecuteSqlQuery(qry);
                                    AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();      
                                    TextBox tbSpecifications = new TextBox() { Text = dt.Rows[0]["Specifications"].ToString() };
                                    tbSpecifications.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                                    tblPart_Details.Controls.Add(tbSpecifications, x, rowCount);
                                    break;
                                }
                            case 2:
                                {
                                    
                                    tbQty = new TextBox() {  Text = "2" };
                                    tbQty.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                                    tblPart_Details.Controls.Add(tbQty, x, rowCount);
                                    break;
                                }
                            case 3:
                                {
                                    tbUnitWeight = new TextBox() { Text = dt.Rows[0]["Weight"].ToString() };
                                    tbUnitWeight.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                                    tblPart_Details.Controls.Add(tbUnitWeight, x, rowCount);
                                    break;
                                }
                            case 4:
                                {
                                    
                                    decimal FinalWeight = int.Parse(tbUnitWeight.Text) * int.Parse(tbQty.Text);
                                    Label lblWeight = new Label() { Text = FinalWeight.ToString() };
                                    lblWeight.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                                    tblPart_Details.Controls.Add(lblWeight, x, rowCount);
                                    break;
                                }

                            }
                        }
                }
                else
                    MessageBox.Show("Please select Component Type to add part ");

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error in filling Parts Details: {0}", ex.Message));
            }
        }

        private void tbQty_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbQty.Text, "  ^ [0-9]"))
            {
                tbQty.Text = "";
            }
        }
        private void tbQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}