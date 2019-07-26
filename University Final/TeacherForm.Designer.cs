namespace University_Final
{
    partial class TeacherForm
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
            this.lblTeacher = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnUserSettings = new System.Windows.Forms.Button();
            this.lblUserID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTeacher
            // 
            this.lblTeacher.BackColor = System.Drawing.Color.DarkRed;
            this.lblTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTeacher.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTeacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTeacher.Location = new System.Drawing.Point(0, 0);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(620, 66);
            this.lblTeacher.TabIndex = 1;
            this.lblTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddStudent.Location = new System.Drawing.Point(167, 147);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(223, 70);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Students";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddQuestion.Location = new System.Drawing.Point(167, 278);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(223, 70);
            this.btnAddQuestion.TabIndex = 5;
            this.btnAddQuestion.Text = "Questions";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnUserSettings
            // 
            this.btnUserSettings.BackColor = System.Drawing.Color.DarkRed;
            this.btnUserSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSettings.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUserSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUserSettings.Location = new System.Drawing.Point(167, 398);
            this.btnUserSettings.Name = "btnUserSettings";
            this.btnUserSettings.Size = new System.Drawing.Size(223, 70);
            this.btnUserSettings.TabIndex = 6;
            this.btnUserSettings.Text = "Profile Settings";
            this.btnUserSettings.UseVisualStyleBackColor = false;
            this.btnUserSettings.Click += new System.EventHandler(this.btnUserSettings_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(478, 115);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(0, 17);
            this.lblUserID.TabIndex = 7;
            this.lblUserID.Visible = false;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(620, 523);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.btnUserSettings);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lblTeacher);
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnUserSettings;
        private System.Windows.Forms.Label lblUserID;
    }
}