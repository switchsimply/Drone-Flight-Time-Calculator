using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using DroneFlightTimeCalculator.MainForms;

namespace DroneFlightTimeCalculator.ProgramFiles
{
    public partial class AddNewComponent : Form
    {
        public AddNewComponent()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //btnSave.Enabled = false;
            UseWaitCursor = true;
            InsertComponentindb();
            UseWaitCursor = false;
            //btnSave.Enabled = true;
            this.Refresh();

        }

        private void txtBoxWeight_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxWeight.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtBoxWeight.Clear();
            }
        }

        private void InsertComponentindb()
        {
            try
            {
                string connectionstring = string.Format("mongodb://test:test123@ds053479.mlab.com:53479/dftcalculatordb/?retryWrites=false");
                string databaseName = string.Format("dftcalculatordb");
                MongoCRUD database = new MongoCRUD(connectionstring, databaseName);
                string dbcollection = string.Format("componentscollection");
                var component = new Component
                {
                    ComponentName = txtBoxComponentName.Text.ToString(),
                    Model = txtBoxModel.Text.ToString(),
                    Specifications = txtBoxSpecifications.Text.ToString(),
                    Weight = int.Parse(txtBoxWeight.Text)
                };
                MongoCRUD.InsertDocument(dbcollection, component);
                MessageBox.Show("Details Entered Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
