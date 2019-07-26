namespace University_Final
{
    partial class AddClass
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
            this.cmbTeachers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.dgwClasses = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(414, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "Teacher:";
            // 
            // cmbTeachers
            // 
            this.cmbTeachers.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbTeachers.FormattingEnabled = true;
            this.cmbTeachers.Location = new System.Drawing.Point(420, 139);
            this.cmbTeachers.Name = "cmbTeachers";
            this.cmbTeachers.Size = new System.Drawing.Size(258, 42);
            this.cmbTeachers.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 36);
            this.label2.TabIndex = 21;
            this.label2.Text = "Subject:";
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(40, 139);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(258, 42);
            this.cmbSubjects.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(744, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 36);
            this.label3.TabIndex = 23;
            this.label3.Text = "Group:";
            // 
            // cmbGroups
            // 
            this.cmbGroups.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(750, 139);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(258, 42);
            this.cmbGroups.TabIndex = 22;
            // 
            // btnAddClass
            // 
            this.btnAddClass.BackColor = System.Drawing.Color.Green;
            this.btnAddClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClass.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddClass.Location = new System.Drawing.Point(444, 235);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(223, 70);
            this.btnAddClass.TabIndex = 24;
            this.btnAddClass.Text = "Create";
            this.btnAddClass.UseVisualStyleBackColor = false;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // dgwClasses
            // 
            this.dgwClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwClasses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwClasses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwClasses.Location = new System.Drawing.Point(0, 329);
            this.dgwClasses.Name = "dgwClasses";
            this.dgwClasses.RowTemplate.Height = 24;
            this.dgwClasses.Size = new System.Drawing.Size(1047, 292);
            this.dgwClasses.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1047, 66);
            this.label4.TabIndex = 26;
            this.label4.Text = "Class Form";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1047, 621);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgwClasses);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbGroups);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSubjects);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTeachers);
            this.Name = "AddClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddClass";
            this.Load += new System.EventHandler(this.AddClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTeachers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.DataGridView dgwClasses;
        private System.Windows.Forms.Label label4;
    }
}