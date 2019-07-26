namespace University_Final
{
    partial class AddSubject
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
            this.pnlAddSubject = new System.Windows.Forms.Panel();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.btnEditSubject = new System.Windows.Forms.Button();
            this.lblCancel = new System.Windows.Forms.Label();
            this.dgwSubjects = new System.Windows.Forms.DataGridView();
            this.btnCreateSubject = new System.Windows.Forms.Button();
            this.txtSubjectname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAddSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddSubject
            // 
            this.pnlAddSubject.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlAddSubject.Controls.Add(this.btnDeleteSubject);
            this.pnlAddSubject.Controls.Add(this.btnEditSubject);
            this.pnlAddSubject.Controls.Add(this.lblCancel);
            this.pnlAddSubject.Controls.Add(this.dgwSubjects);
            this.pnlAddSubject.Controls.Add(this.btnCreateSubject);
            this.pnlAddSubject.Controls.Add(this.txtSubjectname);
            this.pnlAddSubject.Controls.Add(this.label2);
            this.pnlAddSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddSubject.Location = new System.Drawing.Point(0, 0);
            this.pnlAddSubject.Name = "pnlAddSubject";
            this.pnlAddSubject.Size = new System.Drawing.Size(485, 764);
            this.pnlAddSubject.TabIndex = 4;
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.BackColor = System.Drawing.Color.Red;
            this.btnDeleteSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSubject.Enabled = false;
            this.btnDeleteSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSubject.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteSubject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteSubject.Location = new System.Drawing.Point(128, 264);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(223, 70);
            this.btnDeleteSubject.TabIndex = 28;
            this.btnDeleteSubject.Text = "Delete";
            this.btnDeleteSubject.UseVisualStyleBackColor = false;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // btnEditSubject
            // 
            this.btnEditSubject.BackColor = System.Drawing.Color.DarkRed;
            this.btnEditSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSubject.Enabled = false;
            this.btnEditSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSubject.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditSubject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditSubject.Location = new System.Drawing.Point(250, 188);
            this.btnEditSubject.Name = "btnEditSubject";
            this.btnEditSubject.Size = new System.Drawing.Size(223, 70);
            this.btnEditSubject.TabIndex = 27;
            this.btnEditSubject.Text = "Edit";
            this.btnEditSubject.UseVisualStyleBackColor = false;
            this.btnEditSubject.Click += new System.EventHandler(this.btnEditSubject_Click);
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.Location = new System.Drawing.Point(835, 31);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(0, 17);
            this.lblCancel.TabIndex = 4;
            // 
            // dgwSubjects
            // 
            this.dgwSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwSubjects.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSubjects.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwSubjects.Location = new System.Drawing.Point(0, 339);
            this.dgwSubjects.Name = "dgwSubjects";
            this.dgwSubjects.RowTemplate.Height = 24;
            this.dgwSubjects.Size = new System.Drawing.Size(485, 425);
            this.dgwSubjects.TabIndex = 3;
            this.dgwSubjects.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwSubjects_RowHeaderMouseDoubleClick);
            // 
            // btnCreateSubject
            // 
            this.btnCreateSubject.BackColor = System.Drawing.Color.Green;
            this.btnCreateSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateSubject.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateSubject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateSubject.Location = new System.Drawing.Point(12, 188);
            this.btnCreateSubject.Name = "btnCreateSubject";
            this.btnCreateSubject.Size = new System.Drawing.Size(223, 70);
            this.btnCreateSubject.TabIndex = 2;
            this.btnCreateSubject.Text = "Create";
            this.btnCreateSubject.UseVisualStyleBackColor = false;
            this.btnCreateSubject.Click += new System.EventHandler(this.btnCreateSubject_Click);
            // 
            // txtSubjectname
            // 
            this.txtSubjectname.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSubjectname.Location = new System.Drawing.Point(43, 70);
            this.txtSubjectname.Name = "txtSubjectname";
            this.txtSubjectname.Size = new System.Drawing.Size(378, 38);
            this.txtSubjectname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Subject name:";
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 764);
            this.Controls.Add(this.pnlAddSubject);
            this.Name = "AddSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSubject";
            this.Load += new System.EventHandler(this.AddSubject_Load);
            this.pnlAddSubject.ResumeLayout(false);
            this.pnlAddSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSubjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddSubject;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.DataGridView dgwSubjects;
        private System.Windows.Forms.Button btnCreateSubject;
        private System.Windows.Forms.TextBox txtSubjectname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditSubject;
        private System.Windows.Forms.Button btnDeleteSubject;
    }
}