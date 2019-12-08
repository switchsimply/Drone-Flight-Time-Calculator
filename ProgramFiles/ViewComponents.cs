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
        string dbcollection = string.Format("componentscollection");
        public ViewComponents()
        {
            InitializeComponent();
            PopulateDgvComponents();
        }

        private void PopulateDgvComponents()
        {
            List<Component> data = MongoCRUD.LoadAllDocuments<Component>(dbcollection);
            this.dgvComponents.DataSource = data;
            dgvComponents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComponents.BackgroundColor = Color.White;
            dgvComponents.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }
    }
}
