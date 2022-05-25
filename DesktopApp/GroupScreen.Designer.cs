namespace DesktopApp
{
    partial class GroupScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTeachers = new System.Windows.Forms.ComboBox();
            this.cmbShifts = new System.Windows.Forms.ComboBox();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.dgwGroups = new System.Windows.Forms.DataGridView();
            this.lblGroupId = new System.Windows.Forms.Label();
            this.btnUpdateGroup = new System.Windows.Forms.Button();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTeachers
            // 
            this.cmbTeachers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeachers.FormattingEnabled = true;
            this.cmbTeachers.Location = new System.Drawing.Point(291, 50);
            this.cmbTeachers.Name = "cmbTeachers";
            this.cmbTeachers.Size = new System.Drawing.Size(151, 28);
            this.cmbTeachers.TabIndex = 0;
            // 
            // cmbShifts
            // 
            this.cmbShifts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShifts.FormattingEnabled = true;
            this.cmbShifts.Location = new System.Drawing.Point(519, 50);
            this.cmbShifts.Name = "cmbShifts";
            this.cmbShifts.Size = new System.Drawing.Size(151, 28);
            this.cmbShifts.TabIndex = 1;
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(30, 51);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(175, 27);
            this.txtGroupName.TabIndex = 2;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teacher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Shift";
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(30, 125);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(152, 29);
            this.btnAddGroup.TabIndex = 6;
            this.btnAddGroup.Text = "Create Group";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // dgwGroups
            // 
            this.dgwGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGroups.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwGroups.Location = new System.Drawing.Point(0, 187);
            this.dgwGroups.Name = "dgwGroups";
            this.dgwGroups.RowHeadersWidth = 51;
            this.dgwGroups.RowTemplate.Height = 29;
            this.dgwGroups.Size = new System.Drawing.Size(800, 263);
            this.dgwGroups.TabIndex = 7;
            this.dgwGroups.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwGroups_RowHeaderMouseDoubleClick);
            // 
            // lblGroupId
            // 
            this.lblGroupId.AutoSize = true;
            this.lblGroupId.Location = new System.Drawing.Point(301, 125);
            this.lblGroupId.Name = "lblGroupId";
            this.lblGroupId.Size = new System.Drawing.Size(17, 20);
            this.lblGroupId.TabIndex = 8;
            this.lblGroupId.Text = "0";
            this.lblGroupId.Visible = false;
            // 
            // btnUpdateGroup
            // 
            this.btnUpdateGroup.Location = new System.Drawing.Point(347, 121);
            this.btnUpdateGroup.Name = "btnUpdateGroup";
            this.btnUpdateGroup.Size = new System.Drawing.Size(152, 29);
            this.btnUpdateGroup.TabIndex = 9;
            this.btnUpdateGroup.Text = "Update Group";
            this.btnUpdateGroup.UseVisualStyleBackColor = true;
            this.btnUpdateGroup.Visible = false;
            this.btnUpdateGroup.Click += new System.EventHandler(this.btnUpdateGroup_Click);
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.Location = new System.Drawing.Point(517, 121);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(152, 29);
            this.btnDeleteGroup.TabIndex = 10;
            this.btnDeleteGroup.Text = "Delete Group";
            this.btnDeleteGroup.UseVisualStyleBackColor = true;
            this.btnDeleteGroup.Visible = false;
            this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
            // 
            // GroupScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteGroup);
            this.Controls.Add(this.btnUpdateGroup);
            this.Controls.Add(this.lblGroupId);
            this.Controls.Add(this.dgwGroups);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.cmbShifts);
            this.Controls.Add(this.cmbTeachers);
            this.Name = "GroupScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupScreen";
            this.Load += new System.EventHandler(this.GroupScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbTeachers;
        private ComboBox cmbShifts;
        private TextBox txtGroupName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAddGroup;
        private DataGridView dgwGroups;
        private Label lblGroupId;
        private Button btnUpdateGroup;
        private Button btnDeleteGroup;
    }
}