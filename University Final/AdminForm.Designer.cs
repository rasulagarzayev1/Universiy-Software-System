namespace University_Final
{
    partial class AdminForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnAddgroup = new System.Windows.Forms.Button();
            this.btnAddsubject = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(480, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Admin Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddClass);
            this.panel1.Controls.Add(this.btnAddStudent);
            this.panel1.Controls.Add(this.btnAddTeacher);
            this.panel1.Controls.Add(this.btnAddgroup);
            this.panel1.Controls.Add(this.btnAddsubject);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 629);
            this.panel1.TabIndex = 1;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddStudent.Location = new System.Drawing.Point(122, 395);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(223, 70);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.Text = "Students";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeacher.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTeacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddTeacher.Location = new System.Drawing.Point(122, 152);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(223, 70);
            this.btnAddTeacher.TabIndex = 2;
            this.btnAddTeacher.Text = "Teachers";
            this.btnAddTeacher.UseVisualStyleBackColor = false;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnAddgroup
            // 
            this.btnAddgroup.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddgroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddgroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddgroup.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddgroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddgroup.Location = new System.Drawing.Point(122, 269);
            this.btnAddgroup.Name = "btnAddgroup";
            this.btnAddgroup.Size = new System.Drawing.Size(223, 70);
            this.btnAddgroup.TabIndex = 1;
            this.btnAddgroup.Text = "Groups";
            this.btnAddgroup.UseVisualStyleBackColor = false;
            this.btnAddgroup.Click += new System.EventHandler(this.btnAddgroup_Click);
            // 
            // btnAddsubject
            // 
            this.btnAddsubject.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddsubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddsubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddsubject.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddsubject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddsubject.Location = new System.Drawing.Point(122, 36);
            this.btnAddsubject.Name = "btnAddsubject";
            this.btnAddsubject.Size = new System.Drawing.Size(223, 70);
            this.btnAddsubject.TabIndex = 0;
            this.btnAddsubject.Text = "Subjects";
            this.btnAddsubject.UseVisualStyleBackColor = false;
            this.btnAddsubject.Click += new System.EventHandler(this.btnAddsubject_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClass.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddClass.Location = new System.Drawing.Point(122, 497);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(223, 70);
            this.btnAddClass.TabIndex = 4;
            this.btnAddClass.Text = "Classes";
            this.btnAddClass.UseVisualStyleBackColor = false;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 695);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnAddgroup;
        private System.Windows.Forms.Button btnAddsubject;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAddClass;
    }
}