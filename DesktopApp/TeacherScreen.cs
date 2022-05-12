using Business;
using Entities;
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
    public partial class TeacherScreen : Form
    {
        TeacherManager teacherManager = new();
        public TeacherScreen()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var fullname = txtFullname.Text;
            var email = txtEmail.Text;
            var password = txtPassword.Text;

            User user = new()
            {
                Fullname = fullname,
                Email = email,
                Password = password,
            };

            teacherManager.AddTeacher(user);
            MessageBox.Show("Teacher is added.");
            txtFullname.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";

        }
    }
}
