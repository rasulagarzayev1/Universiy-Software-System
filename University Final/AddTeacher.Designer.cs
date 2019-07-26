namespace University_Final
{
    partial class AddTeacher
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
            this.btnEditTeacher = new System.Windows.Forms.Button();
            this.dgwTeachers = new System.Windows.Forms.DataGridView();
            this.dtBirthdate = new System.Windows.Forms.DateTimePicker();
            this.nmUserID = new System.Windows.Forms.NumericUpDown();
            this.btnCreateTeacher = new System.Windows.Forms.Button();
            this.txtPAssword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.pnlAddTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUserID)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddTeacher
            // 
            this.pnlAddTeacher.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlAddTeacher.Controls.Add(this.btnDeleteTeacher);
            this.pnlAddTeacher.Controls.Add(this.btnEditTeacher);
            this.pnlAddTeacher.Controls.Add(this.dgwTeachers);
            this.pnlAddTeacher.Controls.Add(this.dtBirthdate);
            this.pnlAddTeacher.Controls.Add(this.nmUserID);
            this.pnlAddTeacher.Controls.Add(this.btnCreateTeacher);
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
            this.pnlAddTeacher.Size = new System.Drawing.Size(1211, 771);
            this.pnlAddTeacher.TabIndex = 4;
            // 
            // btnEditTeacher
            // 
            this.btnEditTeacher.BackColor = System.Drawing.Color.DarkRed;
            this.btnEditTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditTeacher.Enabled = false;
            this.btnEditTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTeacher.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditTeacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditTeacher.Location = new System.Drawing.Point(706, 300);
            this.btnEditTeacher.Name = "btnEditTeacher";
            this.btnEditTeacher.Size = new System.Drawing.Size(223, 70);
            this.btnEditTeacher.TabIndex = 27;
            this.btnEditTeacher.Text = "Edit";
            this.btnEditTeacher.UseVisualStyleBackColor = false;
            this.btnEditTeacher.Click += new System.EventHandler(this.btnEditTeacher_Click);
            // 
            // dgwTeachers
            // 
            this.dgwTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTeachers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTeachers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwTeachers.Location = new System.Drawing.Point(0, 479);
            this.dgwTeachers.Name = "dgwTeachers";
            this.dgwTeachers.RowTemplate.Height = 24;
            this.dgwTeachers.Size = new System.Drawing.Size(1211, 292);
            this.dgwTeachers.TabIndex = 15;
            this.dgwTeachers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwTeachers_RowHeaderMouseDoubleClick);
            // 
            // dtBirthdate
            // 
            this.dtBirthdate.CalendarFont = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBirthdate.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtBirthdate.Location = new System.Drawing.Point(65, 199);
            this.dtBirthdate.MaxDate = new System.DateTime(1993, 1, 1, 0, 0, 0, 0);
            this.dtBirthdate.Name = "dtBirthdate";
            this.dtBirthdate.Size = new System.Drawing.Size(273, 38);
            this.dtBirthdate.TabIndex = 14;
            this.dtBirthdate.Value = new System.DateTime(1993, 1, 1, 0, 0, 0, 0);
            // 
            // nmUserID
            // 
            this.nmUserID.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmUserID.Location = new System.Drawing.Point(582, 201);
            this.nmUserID.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nmUserID.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmUserID.Name = "nmUserID";
            this.nmUserID.Size = new System.Drawing.Size(273, 38);
            this.nmUserID.TabIndex = 13;
            this.nmUserID.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnCreateTeacher
            // 
            this.btnCreateTeacher.BackColor = System.Drawing.Color.Green;
            this.btnCreateTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTeacher.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateTeacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateTeacher.Location = new System.Drawing.Point(440, 300);
            this.btnCreateTeacher.Name = "btnCreateTeacher";
            this.btnCreateTeacher.Size = new System.Drawing.Size(223, 70);
            this.btnCreateTeacher.TabIndex = 12;
            this.btnCreateTeacher.Text = "Create";
            this.btnCreateTeacher.UseVisualStyleBackColor = false;
            this.btnCreateTeacher.Click += new System.EventHandler(this.btnCreateTeacher_Click);
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
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.BackColor = System.Drawing.Color.Red;
            this.btnDeleteTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTeacher.Enabled = false;
            this.btnDeleteTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTeacher.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteTeacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteTeacher.Location = new System.Drawing.Point(976, 300);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(223, 70);
            this.btnDeleteTeacher.TabIndex = 28;
            this.btnDeleteTeacher.Text = "Delete";
            this.btnDeleteTeacher.UseVisualStyleBackColor = false;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDeleteTeacher_Click);
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 771);
            this.Controls.Add(this.pnlAddTeacher);
            this.Name = "AddTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTeacher";
            this.Load += new System.EventHandler(this.AddTeacher_Load);
            this.pnlAddTeacher.ResumeLayout(false);
            this.pnlAddTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUserID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddTeacher;
        private System.Windows.Forms.DataGridView dgwTeachers;
        private System.Windows.Forms.DateTimePicker dtBirthdate;
        private System.Windows.Forms.NumericUpDown nmUserID;
        private System.Windows.Forms.Button btnCreateTeacher;
        private System.Windows.Forms.TextBox txtPAssword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;
    }
}