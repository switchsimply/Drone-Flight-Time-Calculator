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
        string connectionstring = string.Format("mongodb://test:test123@ds053479.mlab.com:53479/dftcalculatordb/?retryWrites=false");
        string databaseName = string.Format("dftcalculatordb");
        public AddNewComponent()
        {
            InitializeComponent();
            FillTextBox();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Components Added Successfully");
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //btnSave.Enabled = false;
            UseWaitCursor = true;
            InsertComponentindb();
            UseWaitCursor = false;
            //btnSave.Enabled = true;
            this.txtBoxComponentName.Clear();
            this.txtBoxModel.Clear();
            this.txtBoxSpecifications.Clear();
            this.txtBoxWeight.Clear();
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

        List<TextBox> txtBoxListName = new List<TextBox>();
        private void FillTextBox()
        {
            MongoCRUD database = new MongoCRUD(connectionstring, databaseName);
            string dbcollection = string.Format("componentscollection");
            List<Component> data = MongoCRUD.LoadAllDocuments<Component>(dbcollection);
            txtBoxListName = new List<TextBox> { txtBoxComponentName, txtBoxModel, txtBoxSpecifications, txtBoxWeight }; 
            AutoCompleteTextBox(txtBoxListName, data);
        }

        

        private void AutoCompleteTextBox(List <TextBox> txtBoxList,List<Component> listdata)
        {
            AutoCompleteStringCollection sourceName = new AutoCompleteStringCollection();
            MongoCRUD database = new MongoCRUD(connectionstring, databaseName);
            string dbcollection = string.Format("componentscollection");
            foreach(var txtBox in txtBoxList)
            {
                foreach (var component in listdata)
                {
                    if(txtBox == txtBoxComponentName)
                        sourceName.Add(component.ComponentName.ToString());
                    else if (txtBox == txtBoxModel)
                        sourceName.Add(component.Model.ToString());
                    else if (txtBox == txtBoxSpecifications)
                        sourceName.Add(component.Specifications.ToString());
                    else if (txtBox == txtBoxModel)
                        sourceName.Add(component.Weight.ToString());
                }
                txtBox.AutoCompleteCustomSource = sourceName;
                txtBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            
        }
    }
}
