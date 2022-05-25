using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class ShiftScreen : Form
    {
        ShiftManager shiftManager = new();
        public ShiftScreen()
        {
            InitializeComponent();
        }

        private void btnAddShift_Click(object sender, EventArgs e)
        {
            var shift = txtShift.Text;
            shiftManager.addShift(shift);
            MessageBox.Show("ShiftTime is added");
            txtShift.Text = "";
        }

        
    }
}
