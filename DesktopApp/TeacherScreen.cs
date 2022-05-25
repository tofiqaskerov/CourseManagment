using Business;
using DataAccess;
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
        public void FillTeacherDDW()
        {
            dgwTeachers.DataSource = teacherManager.GetAllTeacher();
            dgwTeachers.Columns[2].Visible = false;
            dgwTeachers.Columns[3].Visible = false;
            dgwTeachers.Columns[4].Visible = false;
            dgwTeachers.Columns[5].Visible = false;
            dgwTeachers.Columns[6].Visible = false;



        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var fullname = txtFullname.Text;
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            var emptyFullName = string.IsNullOrEmpty(fullname);
            var emptyEmail = string.IsNullOrEmpty(email);
            var emptyPassowrd = string.IsNullOrEmpty(password);

            var findTeacher = teacherManager.GetTeacherByEmail(email);

            if(findTeacher != null)
            {
                MessageBox.Show("Emial is exist");
            }
            else
            {
                if (emptyFullName || emptyEmail || emptyPassowrd)
                {
                    MessageBox.Show("Bosluqlari doldurun");
                }
                else
                {
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
                    FillTeacherDDW();
                }
            }
            
           
        }

        private void TeacherScreen_Load(object sender, EventArgs e)
        {

            FillTeacherDDW();

        }

        private void dgwTeachers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int userID = (int)dgwTeachers.Rows[e.RowIndex].Cells[6].Value;
            lblId.Text = userID.ToString(); 
            var teacher = teacherManager.GetTeacherById(userID);
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            btnAdd.Visible = false;
            txtFullname.Text = teacher.Fullname;
            txtEmail.Text = teacher.Email;
            txtPassword.Text = teacher.Password;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var fullname = txtFullname.Text;
            var email = txtEmail.Text;
            var password = txtPassword.Text;

            int userId = Convert.ToInt32(lblId.Text);
            var teacher = teacherManager.GetTeacherById(userId);
            teacher.Fullname = fullname;
            teacher.Email = email;
            teacher.Password = password;
            teacherManager.UpdateUser(teacher);
            MessageBox.Show("Teacher is Updated.");
            txtFullname.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnAdd.Visible = true;
            FillTeacherDDW();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure", "Delete Teacher", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                int userId = Convert.ToInt32(lblId.Text);
                var teacher = teacherManager.GetTeacherById(userId);
                teacherManager.DeleteTeacher(teacher);
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                btnAdd.Visible = true;
                FillTeacherDDW();
            }
            else
            {
                txtFullname.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                btnAdd.Visible = true;
            }
           
        }
    }
}
