using DroneFlightTimeCalculator.ProgramFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DroneFlightTimeCalculator.MainForms
{
    public partial class Main : Form
    {
        string dbcollection = string.Format("componentscollection");
        public Main()
        {
            InitializeComponent();
        }

        private void btnAddNewComponent_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            AddNewComponent f2 = new AddNewComponent();
            Cursor.Current = Cursors.Default;
            f2.ShowDialog();
        }

        private void btnViewComponent_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ViewComponents f3 = new ViewComponents();
            Cursor.Current = Cursors.Default;
            f3.ShowDialog();
        }
        private void btnAddComponent_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            List<ProgramFiles.Component> data = MongoCRUD.LoadAllDocuments<ProgramFiles.Component>(dbcollection);
            FillTblComponents();
            txtBoxListName = new List<TextBox> { txtBoxComponentName, txtBoxModel, txtBoxSpecifications, txtBoxWeight };
            foreach (TextBox tb in txtBoxListName)
            {
                AutoCompleteTextBox(tb, data);
            }
            Cursor.Current = Cursors.Default;
            //if(!string.IsNullOrEmpty(txtBoxComponentName.Text) && !string.IsNullOrEmpty(txtBoxQuantity.Text) && !string.IsNullOrEmpty(txtBoxWeight.Text))
                tblComponents.RowCount++;
            //else
            //    MessageBox.Show("First Add Compnent Value Completely");
        }

        List<TextBox> txtBoxListName = new List<TextBox>();
        TextBox txtBoxComponentName = new TextBox();
        TextBox txtBoxModel = new TextBox();
        TextBox txtBoxSpecifications = new TextBox();
        private void FillTblComponents()
        {
            try
            {
                tblComponents.Visible = true;
                int rowCount = tblComponents.RowCount;
                int columnCount = tblComponents.ColumnCount;
                for (int x = 0; x < columnCount; x++)
                {
                    switch (x)
                    {
                        case 0:
                            {
                                txtBoxComponentName = new TextBox();
                                txtBoxComponentName.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                                this.txtBoxComponentName.TextChanged += new System.EventHandler(this.txtBoxComponentName_TextChanged);
                                this.txtBoxComponentName.TabIndex = 0;
                                tblComponents.Controls.Add(txtBoxComponentName, x, rowCount - 1);
                                break;
                            }
                        case 1:
                            {
                                txtBoxModel = new TextBox();
                                txtBoxModel.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                                this.txtBoxModel.TabIndex = 1;
                                tblComponents.Controls.Add(txtBoxModel, x, rowCount - 1);
                                this.txtBoxModel.Enabled = false;
                                this.txtBoxModel.TextChanged += new System.EventHandler(this.txtBoxModel_TextChanged);                             
                                break;
                            }
                        case 2:
                            {
                                txtBoxSpecifications = new TextBox();
                                txtBoxSpecifications.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                                this.txtBoxSpecifications.TabIndex = 2;
                                this.txtBoxSpecifications.Enabled = false;
                                tblComponents.Controls.Add(txtBoxSpecifications, x, rowCount - 1);
                                this.txtBoxSpecifications.TextChanged += new System.EventHandler(this.txtBoxSpecifications_TextChanged);                               
                                break;
                            }
                        case 3:
                            {
                                txtBoxWeight = new TextBox();
                                this.txtBoxWeight.TextChanged += new System.EventHandler(this.txtBoxWeight_TextChanged);
                                txtBoxWeight.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                                this.txtBoxWeight.TabIndex = 3;
                                this.txtBoxWeight.Enabled = false;
                                tblComponents.Controls.Add(txtBoxWeight, x, rowCount - 1);                                
                                break;
                            }
                        case 4:
                            {
                                txtBoxQuantity = new TextBox();
                                this.txtBoxQuantity.TextChanged += new System.EventHandler(this.txtBoxQuantity_TextChanged);
                                txtBoxQuantity.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                                this.txtBoxQuantity.TabIndex = 4;
                                this.txtBoxQuantity.Enabled = false;
                                tblComponents.Controls.Add(txtBoxQuantity, x, rowCount - 1);                              
                                break;
                            }
                        case 5:
                            {
                                lblFinalWeight = new Label();
                                if (!string.IsNullOrEmpty(txtBoxComponentName.Text))
                                {
                                    lblFinalWeight.Text = CalculateFinalWeight();
                                }
                                lblFinalWeight.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                                tblComponents.Controls.Add(lblFinalWeight, x, rowCount - 1);
                                this.lblFinalWeight.TextChanged += new System.EventHandler(this.lblFinalWeight_TextChanged);
                                break;
                            }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error in filling Components: {0}", ex.Message));
            }
        }

        public void AutoCompleteTextBox(TextBox txtBox, List<ProgramFiles.Component> listdata)
        {
            AutoCompleteStringCollection sourceName = new AutoCompleteStringCollection();
            foreach (var component in listdata)
            {
                if (txtBox == txtBoxComponentName)
                    sourceName.Add(component.ComponentName.ToString());
                if (txtBox == txtBoxModel)
                    sourceName.Add(component.Model.ToString());
                if (txtBox == txtBoxSpecifications)
                    sourceName.Add(component.Specifications.ToString());
                if (txtBox == txtBoxWeight)
                    sourceName.Add(component.Weight.ToString());
            }
            txtBox.AutoCompleteCustomSource = sourceName;
            txtBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void txtBoxComponentName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxComponentName.Text))
            {
                txtBoxModel.Enabled = true;
            }
        }

        private void txtBoxModel_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxComponentName.Text) && !string.IsNullOrEmpty(txtBoxModel.Text))
            {
                txtBoxSpecifications.Enabled = true;
            }
            else
                txtBoxSpecifications.Enabled = false;
        }

        private void txtBoxSpecifications_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxComponentName.Text) && !string.IsNullOrEmpty(txtBoxModel.Text))
            {
                txtBoxWeight.Enabled = true;
            }
            else
                txtBoxWeight.Enabled = false;
        }

        private void txtBoxWeight_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxComponentName.Text) && !string.IsNullOrEmpty(txtBoxModel.Text) && !string.IsNullOrEmpty(txtBoxWeight.Text))
            {
                txtBoxQuantity.Enabled = true;
            }
            else
                txtBoxQuantity.Enabled = false;
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxWeight.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtBoxWeight.Clear();
            }
        }
        private void txtBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxQuantity.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtBoxQuantity.Clear();
            }
            else
            {
                CalculateFinalWeight();
            }
        }
        private string CalculateFinalWeight()
        {
            int FinalWeight = 0;
            if (!string.IsNullOrEmpty(txtBoxWeight.Text) && !string.IsNullOrEmpty(txtBoxQuantity.Text))
            {
                FinalWeight = int.Parse(txtBoxWeight.Text) * int.Parse(txtBoxQuantity.Text);
                lblFinalWeight.Text = FinalWeight.ToString();
            }
            return FinalWeight.ToString();
        }
        
        int totalWeight = 0;
        private void lblFinalWeight_TextChanged(object sender, EventArgs e)
        {
            int temptotalWeight =0;
            lblTotalFinalWeight.Visible = true;
            lblTotalFinalWeightValue.Visible = true;
            if (!string.IsNullOrEmpty(lblFinalWeight.Text))
            {
                temptotalWeight = int.Parse(lblFinalWeight.Text.ToString());
            }
            totalWeight = temptotalWeight+ totalWeight;
            lblTotalFinalWeightValue.Text = totalWeight.ToString();
        }
    }
}
