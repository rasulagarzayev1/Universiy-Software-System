namespace University_Final
{
    partial class StudentPointForm
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
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.nmPoint = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dtPointDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.lblUserID = new System.Windows.Forms.Label();
            this.dgwPoints = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nmPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "Subject:";
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(32, 140);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(258, 42);
            this.cmbSubjects.TabIndex = 18;
            this.cmbSubjects.SelectedIndexChanged += new System.EventHandler(this.cmbSubjects_SelectedIndexChanged);
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
            this.lblTeacher.Size = new System.Drawing.Size(972, 66);
            this.lblTeacher.TabIndex = 20;
            this.lblTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(349, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 36);
            this.label3.TabIndex = 22;
            this.label3.Text = "Group:";
            // 
            // cmbGroups
            // 
            this.cmbGroups.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(355, 140);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(258, 42);
            this.cmbGroups.TabIndex = 21;
            this.cmbGroups.SelectedIndexChanged += new System.EventHandler(this.cmbGroups_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(675, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 36);
            this.label4.TabIndex = 24;
            this.label4.Text = "Studdent:";
            // 
            // cmbStudents
            // 
            this.cmbStudents.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(681, 140);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(258, 42);
            this.cmbStudents.TabIndex = 23;
            // 
            // nmPoint
            // 
            this.nmPoint.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmPoint.Location = new System.Drawing.Point(32, 263);
            this.nmPoint.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmPoint.Name = "nmPoint";
            this.nmPoint.Size = new System.Drawing.Size(245, 38);
            this.nmPoint.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(26, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 36);
            this.label5.TabIndex = 26;
            this.label5.Text = "Point:";
            // 
            // dtPointDate
            // 
            this.dtPointDate.CalendarFont = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtPointDate.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtPointDate.Location = new System.Drawing.Point(355, 263);
            this.dtPointDate.MaxDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.dtPointDate.MinDate = new System.DateTime(2018, 11, 21, 0, 0, 0, 0);
            this.dtPointDate.Name = "dtPointDate";
            this.dtPointDate.Size = new System.Drawing.Size(258, 38);
            this.dtPointDate.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(349, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 36);
            this.label6.TabIndex = 28;
            this.label6.Text = "Point Date:";
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPoint.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPoint.Location = new System.Drawing.Point(698, 224);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(223, 135);
            this.btnAddPoint.TabIndex = 29;
            this.btnAddPoint.Text = "Add Point";
            this.btnAddPoint.UseVisualStyleBackColor = false;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(566, 341);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(0, 17);
            this.lblUserID.TabIndex = 30;
            this.lblUserID.Visible = false;
            // 
            // dgwPoints
            // 
            this.dgwPoints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPoints.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPoints.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwPoints.Location = new System.Drawing.Point(0, 435);
            this.dgwPoints.Name = "dgwPoints";
            this.dgwPoints.RowTemplate.Height = 24;
            this.dgwPoints.Size = new System.Drawing.Size(972, 199);
            this.dgwPoints.TabIndex = 31;
            // 
            // StudentPointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(972, 634);
            this.Controls.Add(this.dgwPoints);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.btnAddPoint);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtPointDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nmPoint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbStudents);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbGroups);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSubjects);
            this.Name = "StudentPointForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentPointForm";
            this.Load += new System.EventHandler(this.StudentPointForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.NumericUpDown nmPoint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtPointDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.DataGridView dgwPoints;
    }
}