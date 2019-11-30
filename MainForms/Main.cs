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
        public Main()
        {
            InitializeComponent();
        }

        private void btnAddNewComponent_Click(object sender, EventArgs e)
        {
            AddNewComponent f2 = new AddNewComponent();
            f2.ShowDialog();
        }

        private void btnViewComponent_Click(object sender, EventArgs e)
        {
            ViewComponents f3 = new ViewComponents();
            f3.ShowDialog();
        }
    }
}
