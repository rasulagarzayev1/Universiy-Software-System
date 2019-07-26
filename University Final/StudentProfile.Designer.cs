namespace University_Final
{
    partial class StudentProfile
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
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgwStudentPoint = new System.Windows.Forms.DataGridView();
            this.lblCanPass = new System.Windows.Forms.Label();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartExam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Font = new System.Drawing.Font("Franklin Gothic Demi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudentInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStudentInfo.Location = new System.Drawing.Point(11, 77);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(0, 47);
            this.lblStudentInfo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1209, 66);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Profile";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgwStudentPoint
            // 
            this.dgwStudentPoint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwStudentPoint.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwStudentPoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudentPoint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwStudentPoint.Location = new System.Drawing.Point(0, 471);
            this.dgwStudentPoint.Name = "dgwStudentPoint";
            this.dgwStudentPoint.RowTemplate.Height = 24;
            this.dgwStudentPoint.Size = new System.Drawing.Size(1209, 298);
            this.dgwStudentPoint.TabIndex = 4;
            // 
            // lblCanPass
            // 
            this.lblCanPass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCanPass.Font = new System.Drawing.Font("Franklin Gothic Book", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCanPass.Location = new System.Drawing.Point(0, 384);
            this.lblCanPass.Name = "lblCanPass";
            this.lblCanPass.Size = new System.Drawing.Size(1209, 87);
            this.lblCanPass.TabIndex = 6;
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(18, 241);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(329, 42);
            this.cmbSubjects.TabIndex = 7;
            this.cmbSubjects.SelectedIndexChanged += new System.EventHandler(this.cmbSubjects_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Subject:";
            // 
            // btnStartExam
            // 
            this.btnStartExam.BackColor = System.Drawing.Color.DarkRed;
            this.btnStartExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartExam.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartExam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStartExam.Location = new System.Drawing.Point(893, 223);
            this.btnStartExam.Name = "btnStartExam";
            this.btnStartExam.Size = new System.Drawing.Size(261, 76);
            this.btnStartExam.TabIndex = 9;
            this.btnStartExam.Text = "Start Exam";
            this.btnStartExam.UseVisualStyleBackColor = false;
            this.btnStartExam.Click += new System.EventHandler(this.btnStartExam_Click);
            // 
            // StudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1209, 769);
            this.Controls.Add(this.btnStartExam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSubjects);
            this.Controls.Add(this.lblCanPass);
            this.Controls.Add(this.dgwStudentPoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStudentInfo);
            this.Name = "StudentProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentProfile";
            this.Load += new System.EventHandler(this.StudentProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudentPoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgwStudentPoint;
        private System.Windows.Forms.Label lblCanPass;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartExam;
    }
}