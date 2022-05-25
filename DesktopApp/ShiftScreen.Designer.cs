namespace DesktopApp
{
    partial class ShiftScreen
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
            this.txtShift = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddShift = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(12, 116);
            this.txtShift.Name = "txtShift";
            this.txtShift.PlaceholderText = "Add ShiftTime";
            this.txtShift.Size = new System.Drawing.Size(263, 27);
            this.txtShift.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "ShiftTime Name";
            // 
            // btnAddShift
            // 
            this.btnAddShift.Location = new System.Drawing.Point(12, 185);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(128, 38);
            this.btnAddShift.TabIndex = 2;
            this.btnAddShift.Text = "Add ShiftTime";
            this.btnAddShift.UseVisualStyleBackColor = true;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click);
            // 
            // ShiftScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 450);
            this.Controls.Add(this.btnAddShift);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShift);
            this.Name = "ShiftScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShiftScreen";
        
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtShift;
        private Label label1;
        private Button btnAddShift;
    }
}