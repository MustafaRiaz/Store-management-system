using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            defaultValues();

        }
        private void defaultValues()
        {
            
            dashboardBtn.FlatAppearance.BorderSize = 0;
            medicineBtn.FlatAppearance.BorderSize = 0;
            reportBtn.FlatAppearance.BorderSize = 0;
            reciptBtn.FlatAppearance.BorderSize = 0;
            inventoryBtn.FlatAppearance.BorderSize = 0;
            manufacturerBtn.FlatAppearance.BorderSize = 0;
        }

        private void tableLayoutPanel8_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void dashboardBtn_MouseEnter(object sender, EventArgs e)
        {
            dashboardBtn.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
