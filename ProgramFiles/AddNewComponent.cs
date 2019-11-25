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
            try
            {
                var component = new Component
                {
                     ComponentName = txtBoxComponentName.Text,
                     Model = txtBoxModel.Text,
                     Specifications = txtBoxSpecifications.Text,
                     Weight = int.Parse(txtBoxWeight.Text)
                };
                var client = new MongoClient();
                var database = client.GetDatabase("dftcalculatordb");
                var col = database.GetCollection<Component>("componentscollection");

                col.InsertOneAsync(component);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            
    }
}
