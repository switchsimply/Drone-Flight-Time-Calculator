using DroneFlightTimeCalculator.MainForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DroneFlightTimeCalculator.ProgramFiles
{
    public partial class ViewComponents : Form
    {
        string connectionstring = string.Format("mongodb://test:test123@ds053479.mlab.com:53479/dftcalculatordb/?retryWrites=false");
        string databaseName = string.Format("dftcalculatordb");
        string dbcollection = string.Format("componentscollection");
        public ViewComponents()
        {
            InitializeComponent();
            PopulateDgvComponents();
        }

        private void PopulateDgvComponents()
        {
            MongoCRUD database = new MongoCRUD(connectionstring, databaseName);
            List<Component> data = MongoCRUD.LoadAllDocuments<Component>(dbcollection);
            this.dgvComponents.DataSource = data;
            dgvComponents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComponents.BackgroundColor = Color.White;
            dgvComponents.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }
    }
}
