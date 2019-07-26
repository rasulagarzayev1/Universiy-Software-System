namespace University_Final
{
    partial class AddStudent
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
            this.pnlAddTeacher = new System.Windows.Forms.Panel();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.dgwStudents = new System.Windows.Forms.DataGridView();
            this.dtBirthdate = new System.Windows.Forms.DateTimePicker();
            this.nmUserID = new System.Windows.Forms.NumericUpDown();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.txtPAssword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.pnlAddTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUserID)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddTeacher
            // 
            this.pnlAddTeacher.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlAddTeacher.Controls.Add(this.btnDeleteStudent);
            this.pnlAddTeacher.Controls.Add(this.btnEditStudent);
            this.pnlAddTeacher.Controls.Add(this.label1);
            this.pnlAddTeacher.Controls.Add(this.cmbGroups);
            this.pnlAddTeacher.Controls.Add(this.dgwStudents);
            this.pnlAddTeacher.Controls.Add(this.dtBirthdate);
            this.pnlAddTeacher.Controls.Add(this.nmUserID);
            this.pnlAddTeacher.Controls.Add(this.btnCreateStudent);
            this.pnlAddTeacher.Controls.Add(this.txtPAssword);
            this.pnlAddTeacher.Controls.Add(this.label6);
            this.pnlAddTeacher.Controls.Add(this.label5);
            this.pnlAddTeacher.Controls.Add(this.label4);
            this.pnlAddTeacher.Controls.Add(this.txtLastname);
            this.pnlAddTeacher.Controls.Add(this.label3);
            this.pnlAddTeacher.Controls.Add(this.txtFirstname);
            this.pnlAddTeacher.Controls.Add(this.label2);
            this.pnlAddTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddTeacher.Location = new System.Drawing.Point(0, 0);
            this.pnlAddTeacher.Name = "pnlAddTeacher";
            this.pnlAddTeacher.Size = new System.Drawing.Size(1189, 757);
            this.pnlAddTeacher.TabIndex = 5;
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.BackColor = System.Drawing.Color.DarkRed;
            this.btnEditStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditStudent.Enabled = false;
            this.btnEditStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStudent.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditStudent.Location = new System.Drawing.Point(507, 378);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(223, 70);
            this.btnEditStudent.TabIndex = 27;
            this.btnEditStudent.Text = "Edit";
            this.btnEditStudent.UseVisualStyleBackColor = false;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(591, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "Group:";
            // 
            // cmbGroups
            // 
            this.cmbGroups.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(597, 311);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(258, 42);
            this.cmbGroups.TabIndex = 16;
            // 
            // dgwStudents
            // 
            this.dgwStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwStudents.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwStudents.Location = new System.Drawing.Point(0, 465);
            this.dgwStudents.Name = "dgwStudents";
            this.dgwStudents.RowTemplate.Height = 24;
            this.dgwStudents.Size = new System.Drawing.Size(1189, 292);
            this.dgwStudents.TabIndex = 15;
            this.dgwStudents.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwStudents_RowHeaderMouseDoubleClick);
            // 
            // dtBirthdate
            // 
            this.dtBirthdate.CalendarFont = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBirthdate.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtBirthdate.Location = new System.Drawing.Point(65, 199);
            this.dtBirthdate.MaxDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.dtBirthdate.Name = "dtBirthdate";
            this.dtBirthdate.Size = new System.Drawing.Size(273, 38);
            this.dtBirthdate.TabIndex = 14;
            this.dtBirthdate.Value = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            // 
            // nmUserID
            // 
            this.nmUserID.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmUserID.Location = new System.Drawing.Point(582, 201);
            this.nmUserID.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nmUserID.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmUserID.Name = "nmUserID";
            this.nmUserID.Size = new System.Drawing.Size(273, 38);
            this.nmUserID.TabIndex = 13;
            this.nmUserID.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.BackColor = System.Drawing.Color.Green;
            this.btnCreateStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateStudent.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateStudent.Location = new System.Drawing.Point(216, 378);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(223, 70);
            this.btnCreateStudent.TabIndex = 12;
            this.btnCreateStudent.Text = "Create";
            this.btnCreateStudent.UseVisualStyleBackColor = false;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click_1);
            // 
            // txtPAssword
            // 
            this.txtPAssword.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPAssword.Location = new System.Drawing.Point(65, 315);
            this.txtPAssword.Name = "txtPAssword";
            this.txtPAssword.Size = new System.Drawing.Size(273, 38);
            this.txtPAssword.TabIndex = 11;
            this.txtPAssword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(59, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(576, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "User ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(59, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birthdate:";
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLastname.Location = new System.Drawing.Point(582, 84);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(273, 38);
            this.txtLastname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(576, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lastname:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFirstname.Location = new System.Drawing.Point(65, 84);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(273, 38);
            this.txtFirstname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(59, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Firstname:";
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.Red;
            this.btnDeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStudent.Enabled = false;
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteStudent.Location = new System.Drawing.Point(797, 378);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(223, 70);
            this.btnDeleteStudent.TabIndex = 45;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 757);
            this.Controls.Add(this.pnlAddTeacher);
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.pnlAddTeacher.ResumeLayout(false);
            this.pnlAddTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUserID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.DataGridView dgwStudents;
        private System.Windows.Forms.DateTimePicker dtBirthdate;
        private System.Windows.Forms.NumericUpDown nmUserID;
        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.TextBox txtPAssword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
    }
}