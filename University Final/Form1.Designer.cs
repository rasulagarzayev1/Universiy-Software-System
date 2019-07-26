namespace University_Final
{
    partial class Form1
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
            this.Login = new System.Windows.Forms.Label();
            this.txtIdentifacator = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbTeacher = new System.Windows.Forms.RadioButton();
            this.rbStudent = new System.Windows.Forms.RadioButton();
            this.tnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.DarkRed;
            this.Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Login.Location = new System.Drawing.Point(0, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(470, 46);
            this.Login.TabIndex = 0;
            this.Login.Text = "LOGIN";
            this.Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIdentifacator
            // 
            this.txtIdentifacator.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIdentifacator.Location = new System.Drawing.Point(34, 144);
            this.txtIdentifacator.Name = "txtIdentifacator";
            this.txtIdentifacator.Size = new System.Drawing.Size(408, 38);
            this.txtIdentifacator.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "User ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(34, 252);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(408, 38);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAdmin.Location = new System.Drawing.Point(34, 296);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(110, 40);
            this.rbAdmin.TabIndex = 5;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbTeacher
            // 
            this.rbTeacher.AutoSize = true;
            this.rbTeacher.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbTeacher.Location = new System.Drawing.Point(150, 296);
            this.rbTeacher.Name = "rbTeacher";
            this.rbTeacher.Size = new System.Drawing.Size(132, 40);
            this.rbTeacher.TabIndex = 6;
            this.rbTeacher.Text = "Teacher";
            this.rbTeacher.UseVisualStyleBackColor = true;
            // 
            // rbStudent
            // 
            this.rbStudent.AutoSize = true;
            this.rbStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbStudent.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbStudent.Location = new System.Drawing.Point(288, 296);
            this.rbStudent.Name = "rbStudent";
            this.rbStudent.Size = new System.Drawing.Size(130, 40);
            this.rbStudent.TabIndex = 7;
            this.rbStudent.Text = "Student";
            this.rbStudent.UseVisualStyleBackColor = true;
            // 
            // tnLogin
            // 
            this.tnLogin.BackColor = System.Drawing.Color.DarkRed;
            this.tnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tnLogin.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tnLogin.Location = new System.Drawing.Point(133, 377);
            this.tnLogin.Name = "tnLogin";
            this.tnLogin.Size = new System.Drawing.Size(187, 53);
            this.tnLogin.TabIndex = 8;
            this.tnLogin.Text = "Login";
            this.tnLogin.UseVisualStyleBackColor = false;
            this.tnLogin.Click += new System.EventHandler(this.tnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(470, 470);
            this.Controls.Add(this.tnLogin);
            this.Controls.Add(this.rbStudent);
            this.Controls.Add(this.rbTeacher);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdentifacator);
            this.Controls.Add(this.Login);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox txtIdentifacator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbTeacher;
        private System.Windows.Forms.RadioButton rbStudent;
        private System.Windows.Forms.Button tnLogin;
    }
}

