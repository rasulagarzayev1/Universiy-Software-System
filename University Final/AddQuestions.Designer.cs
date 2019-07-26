namespace University_Final
{
    partial class AddQuestions
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuestionContent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVariantA = new System.Windows.Forms.TextBox();
            this.txtVariantB = new System.Windows.Forms.TextBox();
            this.txtVariantC = new System.Windows.Forms.TextBox();
            this.rbCorrectA = new System.Windows.Forms.RadioButton();
            this.rbCorrectB = new System.Windows.Forms.RadioButton();
            this.rbCorrectC = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.dgwQuestions = new System.Windows.Forms.DataGridView();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwQuestions)).BeginInit();
            this.SuspendLayout();
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
            this.label4.Size = new System.Drawing.Size(1205, 86);
            this.label4.TabIndex = 27;
            this.label4.Text = "ADD QUESTIONS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuestionContent
            // 
            this.txtQuestionContent.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtQuestionContent.Location = new System.Drawing.Point(23, 133);
            this.txtQuestionContent.MaxLength = 99999;
            this.txtQuestionContent.Name = "txtQuestionContent";
            this.txtQuestionContent.Size = new System.Drawing.Size(1154, 38);
            this.txtQuestionContent.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 36);
            this.label3.TabIndex = 28;
            this.label3.Text = "Question Content:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(89, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 36);
            this.label1.TabIndex = 30;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(89, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 36);
            this.label2.TabIndex = 31;
            this.label2.Text = "C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(89, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 36);
            this.label5.TabIndex = 32;
            this.label5.Text = "B";
            // 
            // txtVariantA
            // 
            this.txtVariantA.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtVariantA.Location = new System.Drawing.Point(128, 187);
            this.txtVariantA.Name = "txtVariantA";
            this.txtVariantA.Size = new System.Drawing.Size(1012, 38);
            this.txtVariantA.TabIndex = 33;
            // 
            // txtVariantB
            // 
            this.txtVariantB.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtVariantB.Location = new System.Drawing.Point(128, 262);
            this.txtVariantB.Name = "txtVariantB";
            this.txtVariantB.Size = new System.Drawing.Size(1026, 38);
            this.txtVariantB.TabIndex = 34;
            // 
            // txtVariantC
            // 
            this.txtVariantC.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtVariantC.Location = new System.Drawing.Point(128, 340);
            this.txtVariantC.Name = "txtVariantC";
            this.txtVariantC.Size = new System.Drawing.Size(1026, 38);
            this.txtVariantC.TabIndex = 35;
            // 
            // rbCorrectA
            // 
            this.rbCorrectA.AutoSize = true;
            this.rbCorrectA.Location = new System.Drawing.Point(1160, 200);
            this.rbCorrectA.Name = "rbCorrectA";
            this.rbCorrectA.Size = new System.Drawing.Size(17, 16);
            this.rbCorrectA.TabIndex = 36;
            this.rbCorrectA.TabStop = true;
            this.rbCorrectA.UseVisualStyleBackColor = true;
            // 
            // rbCorrectB
            // 
            this.rbCorrectB.AutoSize = true;
            this.rbCorrectB.Location = new System.Drawing.Point(1160, 278);
            this.rbCorrectB.Name = "rbCorrectB";
            this.rbCorrectB.Size = new System.Drawing.Size(17, 16);
            this.rbCorrectB.TabIndex = 37;
            this.rbCorrectB.TabStop = true;
            this.rbCorrectB.UseVisualStyleBackColor = true;
            // 
            // rbCorrectC
            // 
            this.rbCorrectC.AutoSize = true;
            this.rbCorrectC.Location = new System.Drawing.Point(1160, 353);
            this.rbCorrectC.Name = "rbCorrectC";
            this.rbCorrectC.Size = new System.Drawing.Size(17, 16);
            this.rbCorrectC.TabIndex = 38;
            this.rbCorrectC.TabStop = true;
            this.rbCorrectC.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(122, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 36);
            this.label6.TabIndex = 40;
            this.label6.Text = "Subject:";
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(128, 419);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(352, 42);
            this.cmbSubjects.TabIndex = 39;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.Green;
            this.btnAddQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddQuestion.Location = new System.Drawing.Point(517, 404);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(194, 70);
            this.btnAddQuestion.TabIndex = 41;
            this.btnAddQuestion.Text = "Create";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.BackColor = System.Drawing.Color.DarkRed;
            this.btnEditQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditQuestion.Enabled = false;
            this.btnEditQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditQuestion.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditQuestion.Location = new System.Drawing.Point(743, 404);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(194, 70);
            this.btnEditQuestion.TabIndex = 42;
            this.btnEditQuestion.Text = "Edit";
            this.btnEditQuestion.UseVisualStyleBackColor = false;
            this.btnEditQuestion.Click += new System.EventHandler(this.btnEditQuestion_Click);
            // 
            // dgwQuestions
            // 
            this.dgwQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwQuestions.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwQuestions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwQuestions.Location = new System.Drawing.Point(0, 521);
            this.dgwQuestions.Name = "dgwQuestions";
            this.dgwQuestions.RowTemplate.Height = 24;
            this.dgwQuestions.Size = new System.Drawing.Size(1205, 241);
            this.dgwQuestions.TabIndex = 43;
            this.dgwQuestions.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwQuestions_RowHeaderMouseDoubleClick);
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.BackColor = System.Drawing.Color.Red;
            this.btnDeleteQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteQuestion.Enabled = false;
            this.btnDeleteQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteQuestion.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteQuestion.Location = new System.Drawing.Point(963, 404);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(191, 70);
            this.btnDeleteQuestion.TabIndex = 44;
            this.btnDeleteQuestion.Text = "Delete";
            this.btnDeleteQuestion.UseVisualStyleBackColor = false;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // AddQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1205, 762);
            this.Controls.Add(this.btnDeleteQuestion);
            this.Controls.Add(this.dgwQuestions);
            this.Controls.Add(this.btnEditQuestion);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSubjects);
            this.Controls.Add(this.rbCorrectC);
            this.Controls.Add(this.rbCorrectB);
            this.Controls.Add(this.rbCorrectA);
            this.Controls.Add(this.txtVariantC);
            this.Controls.Add(this.txtVariantB);
            this.Controls.Add(this.txtVariantA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuestionContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "AddQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuestions";
            this.Load += new System.EventHandler(this.AddQuestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuestionContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVariantA;
        private System.Windows.Forms.TextBox txtVariantB;
        private System.Windows.Forms.TextBox txtVariantC;
        private System.Windows.Forms.RadioButton rbCorrectA;
        private System.Windows.Forms.RadioButton rbCorrectB;
        private System.Windows.Forms.RadioButton rbCorrectC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.DataGridView dgwQuestions;
        private System.Windows.Forms.Button btnDeleteQuestion;
    }
}