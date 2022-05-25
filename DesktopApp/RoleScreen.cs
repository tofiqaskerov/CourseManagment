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
    public partial class RoleScreen : Form
    {
        RoleManager roleManager = new();
        public RoleScreen()
        {
            InitializeComponent();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            var roleName = txtAddRole.Text;
            roleManager.AddRole(roleName);
            MessageBox.Show("Role is added.");
            txtAddRole.Text = "";
        }

        private void RoleScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
