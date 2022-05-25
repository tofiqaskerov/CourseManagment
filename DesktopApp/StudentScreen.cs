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
    public partial class StudentScreen : Form
    {
        PaymentManager _paymentManager = new();
        GroupManager _groupManager = new();
        StudentManager _studentManager = new();
        
        public StudentScreen()
        {
            InitializeComponent();
        }
        public void FillDGV()
        {
            var studentsList = _studentManager.GetAllStudents().Select(student => new
            {
                Id = student.Id,
                Email = student.Email,
                Phone = String.Format("{0:+(### ##) ###-##-##}",Convert.ToInt64(student.Number) ),

            }).ToList();
            DgvStudents.DataSource = studentsList;
            
        }
        private void StudentScreen_Load(object sender, EventArgs e)
        {
            var groups = _groupManager.GetAllGroups();
            foreach (var group in groups)
            {
                CmbGroups.Items.Add(group.Name);
            }
            FillDGV();
        }
        
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string studentName = TxtFullName.Text;
            string email = TxtEmail.Text;
            string number = TxtNumber.Text;
            string selectedGroup = CmbGroups.Text;
            double generalPrice = (double)NmrGeneralPrice.Value;
            double payment = (double)NmrPayment.Value;
            try
            {
                var group = _groupManager.GetGroupByName(selectedGroup);
                Random rnd = new();
                Student student = new()
                {
                    Fullname = studentName,
                    Email = email,
                    Number = number,
                    GroupId = group.Id,
                    Password = rnd.Next(0, 100000).ToString(),
                    MainPrice = generalPrice,
                };
                var students = _studentManager.AddStudent(student);
                _paymentManager.AddPayment(students.Id, payment);
                studentName = "";
                email = "";
                number = "";
                selectedGroup = "";
                MessageBox.Show("Student is added");
                FillDGV();
            }
            catch (Exception)
            {
                MessageBox.Show("Something is wrong.", "Error", MessageBoxButtons.OK);
                
            }
            

        }

        private void DgvStudents_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var studentId = (int)DgvStudents.Rows[e.RowIndex].Cells[0].Value;
            var student = _studentManager.GetStudentById(studentId);
            var payment = _paymentManager.GetPaymentListById(studentId);
            lblStudentId.Text = studentId.ToString();
            TxtFullName.Text = student.Fullname;
            TxtEmail.Text = student.Email;
            TxtNumber.Text = student.Number;
            CmbGroups.Text = student.Groups.Name;
            NmrGeneralPrice.Value = (decimal)student.MainPrice;
            NmrPayment.Value = (decimal)payment.Price;
            BtnUpdate.Visible = true;
            BtnDelete.Visible = true;
            BtnAdd.Visible = false;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int StudentId = Convert.ToInt32(lblStudentId.Text);
            var student = _studentManager.GetStudentById(StudentId); 
            var payment = _paymentManager.GetPaymentListById(StudentId);
            student.Fullname = TxtFullName.Text;
            student.Email = TxtEmail.Text;
            student.Number = TxtNumber.Text;
            student.MainPrice = (double)NmrGeneralPrice.Value;
            payment.Price = (double)NmrPayment.Value;
            _studentManager.UpdateStudent(student, payment);
            TxtFullName.Text = "";
            TxtEmail.Text = "";
            TxtNumber.Text = "";
            NmrGeneralPrice.Value = 0;
            NmrPayment.Value = 0;
            FillDGV();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(lblStudentId.Text);
            DialogResult result = MessageBox.Show("Are you sure?", "Delete Student", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                _studentManager.DeleteGroup(studentId);
            }
            TxtFullName.Text = "";
            TxtEmail.Text = "";
            TxtNumber.Text = "";
            NmrGeneralPrice.Value = 0;
            NmrPayment.Value = 0;
            FillDGV();
        }
    }
}
