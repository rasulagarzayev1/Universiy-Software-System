namespace University_Final
{
    partial class studentSettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 66);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLastname.Location = new System.Drawing.Point(59, 207);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(273, 38);
            this.txtLastname.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(53, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 36);
            this.label5.TabIndex = 42;
            this.label5.Text = "Lastname:";
            // 
            // dtBirthdate
            // 
            this.dtBirthdate.CalendarFont = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBirthdate.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtBirthdate.Location = new System.Drawing.Point(59, 297);
            this.dtBirthdate.MaxDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.dtBirthdate.Name = "dtBirthdate";
            this.dtBirthdate.Size = new System.Drawing.Size(273, 38);
            this.dtBirthdate.TabIndex = 41;
            this.dtBirthdate.Value = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(53, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 36);
            this.label4.TabIndex = 40;
            this.label4.Text = "Birthdate:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFirstname.Location = new System.Drawing.Point(55, 118);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(273, 38);
            this.txtFirstname.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 36);
            this.label3.TabIndex = 38;
            this.label3.Text = "Firstname:";
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.BackColor = System.Drawing.Color.DarkRed;
            this.btnEditStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStudent.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditStudent.Location = new System.Drawing.Point(76, 458);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(223, 70);
            this.btnEditStudent.TabIndex = 37;
            this.btnEditStudent.Text = "Edit";
            this.btnEditStudent.UseVisualStyleBackColor = false;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 36);
            this.label2.TabIndex = 36;
            this.label2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(59, 395);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(269, 38);
            this.txtPassword.TabIndex = 35;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // studentSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(389, 565);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtBirthdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEditStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Name = "studentSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "studentSettingsForm";
            this.Load += new System.EventHandler(this.studentSettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtBirthdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
    }
}