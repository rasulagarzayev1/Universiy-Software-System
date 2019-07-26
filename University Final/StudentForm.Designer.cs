namespace University_Final
{
    partial class StudentForm
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
            this.btnProfileSettings = new System.Windows.Forms.Button();
            this.btnYourProfile = new System.Windows.Forms.Button();
            this.lblUserID = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(421, 66);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome Student Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProfileSettings
            // 
            this.btnProfileSettings.BackColor = System.Drawing.Color.DarkRed;
            this.btnProfileSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfileSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfileSettings.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProfileSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProfileSettings.Location = new System.Drawing.Point(94, 243);
            this.btnProfileSettings.Name = "btnProfileSettings";
            this.btnProfileSettings.Size = new System.Drawing.Size(223, 70);
            this.btnProfileSettings.TabIndex = 7;
            this.btnProfileSettings.Text = "Profile Settings";
            this.btnProfileSettings.UseVisualStyleBackColor = false;
            this.btnProfileSettings.Click += new System.EventHandler(this.btnProfileSettings_Click);
            // 
            // btnYourProfile
            // 
            this.btnYourProfile.BackColor = System.Drawing.Color.DarkRed;
            this.btnYourProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYourProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYourProfile.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnYourProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYourProfile.Location = new System.Drawing.Point(94, 122);
            this.btnYourProfile.Name = "btnYourProfile";
            this.btnYourProfile.Size = new System.Drawing.Size(223, 70);
            this.btnYourProfile.TabIndex = 8;
            this.btnYourProfile.Text = "Your Profile";
            this.btnYourProfile.UseVisualStyleBackColor = false;
            this.btnYourProfile.Click += new System.EventHandler(this.btnYourProfile_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(362, 94);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(0, 17);
            this.lblUserID.TabIndex = 9;
            this.lblUserID.Visible = false;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(421, 367);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.btnYourProfile);
            this.Controls.Add(this.btnProfileSettings);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProfileSettings;
        private System.Windows.Forms.Button btnYourProfile;
        private System.Windows.Forms.Label lblUserID;
    }
}