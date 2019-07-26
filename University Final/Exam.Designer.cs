namespace University_Final
{
    partial class Exam
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
            this.btnFinishExam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFinishExam
            // 
            this.btnFinishExam.BackColor = System.Drawing.Color.DarkRed;
            this.btnFinishExam.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFinishExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishExam.Font = new System.Drawing.Font("Franklin Gothic Book", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFinishExam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinishExam.Location = new System.Drawing.Point(1125, 0);
            this.btnFinishExam.Name = "btnFinishExam";
            this.btnFinishExam.Size = new System.Drawing.Size(192, 762);
            this.btnFinishExam.TabIndex = 4;
            this.btnFinishExam.Text = "Finish";
            this.btnFinishExam.UseVisualStyleBackColor = false;
            this.btnFinishExam.Click += new System.EventHandler(this.btnFinishExam_Click);
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1317, 762);
            this.Controls.Add(this.btnFinishExam);
            this.Name = "Exam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Exam_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFinishExam;
    }
}