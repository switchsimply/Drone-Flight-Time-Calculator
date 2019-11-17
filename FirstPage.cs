using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drone_Calculations
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            DroneFlightTimeCalculator f2 = new DroneFlightTimeCalculator(); //this is the change, code for redirect  
            f2.ShowDialog();
            this.Close();
        }
    }   
}
