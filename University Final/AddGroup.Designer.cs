namespace University_Final
{
    partial class AddGroup
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
            this.pnlAddGroup = new System.Windows.Forms.Panel();
            this.btnEditGroup = new System.Windows.Forms.Button();
            this.dgwGroups = new System.Windows.Forms.DataGridView();
            this.btnCreateGroup = new System.Windows.Forms.Button();
            this.txtGroupname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.pnlAddGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddGroup
            // 
            this.pnlAddGroup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlAddGroup.Controls.Add(this.btnDeleteGroup);
            this.pnlAddGroup.Controls.Add(this.btnEditGroup);
            this.pnlAddGroup.Controls.Add(this.dgwGroups);
            this.pnlAddGroup.Controls.Add(this.btnCreateGroup);
            this.pnlAddGroup.Controls.Add(this.txtGroupname);
            this.pnlAddGroup.Controls.Add(this.label2);
            this.pnlAddGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddGroup.Location = new System.Drawing.Point(0, 0);
            this.pnlAddGroup.Name = "pnlAddGroup";
            this.pnlAddGroup.Size = new System.Drawing.Size(507, 769);
            this.pnlAddGroup.TabIndex = 5;
            // 
            // btnEditGroup
            // 
            this.btnEditGroup.BackColor = System.Drawing.Color.DarkRed;
            this.btnEditGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditGroup.Enabled = false;
            this.btnEditGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditGroup.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditGroup.Location = new System.Drawing.Point(166, 186);
            this.btnEditGroup.Name = "btnEditGroup";
            this.btnEditGroup.Size = new System.Drawing.Size(170, 84);
            this.btnEditGroup.TabIndex = 27;
            this.btnEditGroup.Text = "Edit";
            this.btnEditGroup.UseVisualStyleBackColor = false;
            this.btnEditGroup.Click += new System.EventHandler(this.btnEditGroup_Click);
            // 
            // dgwGroups
            // 
            this.dgwGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwGroups.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGroups.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwGroups.Location = new System.Drawing.Point(0, 344);
            this.dgwGroups.Name = "dgwGroups";
            this.dgwGroups.RowTemplate.Height = 24;
            this.dgwGroups.Size = new System.Drawing.Size(507, 425);
            this.dgwGroups.TabIndex = 3;
            this.dgwGroups.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwGroups_RowHeaderMouseDoubleClick);
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.BackColor = System.Drawing.Color.Green;
            this.btnCreateGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateGroup.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateGroup.Location = new System.Drawing.Point(12, 186);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(148, 84);
            this.btnCreateGroup.TabIndex = 2;
            this.btnCreateGroup.Text = "Create";
            this.btnCreateGroup.UseVisualStyleBackColor = false;
            this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
            // 
            // txtGroupname
            // 
            this.txtGroupname.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtGroupname.Location = new System.Drawing.Point(43, 70);
            this.txtGroupname.Name = "txtGroupname";
            this.txtGroupname.Size = new System.Drawing.Size(389, 38);
            this.txtGroupname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Group name:";
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteGroup.Enabled = false;
            this.btnDeleteGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGroup.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteGroup.Location = new System.Drawing.Point(342, 186);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(153, 84);
            this.btnDeleteGroup.TabIndex = 28;
            this.btnDeleteGroup.Text = "Delete";
            this.btnDeleteGroup.UseVisualStyleBackColor = false;
            this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 769);
            this.Controls.Add(this.pnlAddGroup);
            this.Name = "AddGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddGroup";
            this.Load += new System.EventHandler(this.AddGroup_Load);
            this.pnlAddGroup.ResumeLayout(false);
            this.pnlAddGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddGroup;
        private System.Windows.Forms.DataGridView dgwGroups;
        private System.Windows.Forms.Button btnCreateGroup;
        private System.Windows.Forms.TextBox txtGroupname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditGroup;
        private System.Windows.Forms.Button btnDeleteGroup;
    }
}