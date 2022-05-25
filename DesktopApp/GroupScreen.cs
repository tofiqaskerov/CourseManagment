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
    public partial class GroupScreen : Form
    {
        GroupManager groupManager = new();
        TeacherManager teacherManager = new TeacherManager();
        ShiftManager shiftManager = new ShiftManager();
        public GroupScreen()
        {
            InitializeComponent();
        }
        public void DGVGroups()
        {
            dgwGroups.DataSource = groupManager.GetAllGroups().Select(x => new
            {
                Id = x.Id,
                GroupName = x.Name,
                Shift = x.ShiftTime.Name,
                Teacher = x.User.Fullname
            }).ToList();
        }
        private void GroupScreen_Load(object sender, EventArgs e)
        {
            var teachers = teacherManager.GetAllTeacher();
            foreach (var teacher in teachers)
            {
                cmbTeachers.Items.Add(teacher.Fullname);
            }

            var shifts = shiftManager.GetShiftTimes();
            foreach (var shift in shifts)
            {
                cmbShifts.Items.Add(shift.Name);
            }

            DGVGroups();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            string groupName = txtGroupName.Text;
            string selectedTeacher = cmbTeachers.Text;
            string selectedShift = cmbShifts.Text;

            var teacher = teacherManager.GetTeacherByName(selectedTeacher);
            var shift = shiftManager.GetShiftByName(selectedShift);
            Group group = new()
            {
                Name = groupName,
                ShiftTimeId = shift.Id,
                UserId = teacher.Id
            };
            groupManager.AddGroup(group);
            groupName = "";
            selectedShift = "";
            selectedTeacher = "";
            DGVGroups();
        }

        private void dgwGroups_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var groupId = (int)dgwGroups.Rows[e.RowIndex].Cells[0].Value;
            var group = groupManager.GetGroupById(groupId);
            lblGroupId.Text = Convert.ToString(groupId); 
            txtGroupName.Text = group.Name;
            cmbTeachers.Text = group.User.Fullname;
            cmbShifts.Text = group.ShiftTime.Name;
            btnUpdateGroup.Visible = true;
            btnDeleteGroup.Visible = true;
        }
       
        private void btnUpdateGroup_Click(object sender, EventArgs e)
        {
            int groupId = Convert.ToInt32(lblGroupId.Text);
            var group = groupManager.GetGroupById(groupId);
            var teacher = teacherManager.GetTeacherByName(cmbTeachers.Text);
            var shift = shiftManager.GetShiftByName(cmbShifts.Text);
            group.Name = txtGroupName.Text;
            group.UserId = teacher.Id;
            group.ShiftTimeId = shift.Id;
            groupManager.UpdateGroup(group);
            txtGroupName.Text = "";
            cmbTeachers.Text = "";
            cmbShifts.Text = "";
            DGVGroups();
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            int GroupId = Convert.ToInt32(lblGroupId.Text);
            DialogResult result = MessageBox.Show("Are you sure?", "Delete Group", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                groupManager.DeleteGroup(GroupId);
                
            }
            DGVGroups();

        }

       
    }
}
