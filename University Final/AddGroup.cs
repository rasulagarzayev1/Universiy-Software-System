using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_Final.Extensions;
using University_Final.Model;

namespace University_Final
{
    public partial class AddGroup : Form
    {
        private readonly UniversityEntities db;
        Group Selectedgroup;
        public AddGroup()
        {
            InitializeComponent();
            db = new UniversityEntities();
        }
        void updateGroupsDataGrid()
        {
            dgwGroups.DataSource = db.Groups.Where(g => g.Status == true).Select(g => new
            {
                g.ID,
                g.Name,
                g.Status
            }).ToList();
        }
        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            string groupName = txtGroupname.Text;

            Subject subject = db.Subjects.FirstOrDefault(s => s.Name == groupName);

            if (subject != null)
            {
                MessageBox.Show("Group with this name is already exists", "Creation Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(groupName))
            {
                MessageBox.Show("Please enter groupname correctly", "Creation Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Group newGroup = new Group
            {
                Name = groupName,
                Status = true
            };
            db.Groups.Add(newGroup);
            db.SaveChanges();
            txtGroupname.Clear();
            MessageBox.Show($"Group {groupName} created successfully!", "Creation Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            updateGroupsDataGrid();

        }

        private void AddGroup_Load(object sender, EventArgs e)
        {
            updateGroupsDataGrid();
        }

       
        private void dgwGroups_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEditGroup.Enabled = true;
            btnCreateGroup.Enabled = false;
            btnDeleteGroup.Enabled = true;

            int id = (int)dgwGroups.Rows[e.RowIndex].Cells[0].Value;
            Selectedgroup = db.Groups.Find(id);
            txtGroupname.Text = Selectedgroup.Name;
            string selectedGroupName = Selectedgroup.Name;

            

        }
        private void btnEditGroup_Click(object sender, EventArgs e)
        {
            string newGroupName = txtGroupname.Text;

            

            if (String.IsNullOrEmpty(newGroupName))
            {
                MessageBox.Show("Please edit group name correctly", "Edit Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Selectedgroup.Name = newGroupName;
            MessageBox.Show($"Group name edited successfully", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtGroupname.Text = "";
            btnCreateGroup.Enabled = true;
            btnEditGroup.Enabled = false;
            btnDeleteGroup.Enabled = false;
            db.SaveChanges();
            updateGroupsDataGrid();
        }

        

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            string selectedGroupName = Selectedgroup.Name;
            DialogResult result =
                       MessageBox.Show($"Are you sure to delete {selectedGroupName}?",
                    "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Selectedgroup.Status = false;
            }
            MessageBox.Show($"Group {selectedGroupName} removed successfully from your system", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtGroupname.Text = "";
            btnCreateGroup.Enabled = true;
            btnEditGroup.Enabled = false;
            btnDeleteGroup.Enabled = false;
            db.SaveChanges();
            updateGroupsDataGrid();
        }
    }
}
