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
    public partial class AddSubject : Form
    {
        private readonly UniversityEntities db;
        Subject selectedSubject;
        public AddSubject()
        {
            InitializeComponent();
            db = new UniversityEntities();
        }
        void updateSubjectsDataGrid()
        {
            dgwSubjects.DataSource = db.Subjects.Where(s => s.Status == true).Select(s => new
            {
                s.ID,
                s.Name,
                s.Status
            }).ToList();

            dgwSubjects.Columns[0].Visible = false;
        }


        private void AddSubject_Load(object sender, EventArgs e)
        {
            updateSubjectsDataGrid();
        }



        private void btnCreateSubject_Click(object sender, EventArgs e)
        {
            string subjectName = txtSubjectname.Text.Trim();

            Subject subject = db.Subjects.FirstOrDefault(s => s.Name.ToLower() == subjectName.ToLower());

            if (subject != null)
            {
                MessageBox.Show("Subject with this name is already exists", "Creation Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(subjectName))
            {
                MessageBox.Show("Please enter subjectname correctly", "Creation Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Subject newSubject = new Subject
            {
                Name = subjectName,
                Status = true
            };
            db.Subjects.Add(newSubject);
            db.SaveChanges();
            txtSubjectname.Clear();
            MessageBox.Show($"Subject {subjectName} created successfully!", "Creation Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            updateSubjectsDataGrid();
            txtSubjectname.Clear();
        }



        private void dgwSubjects_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEditSubject.Enabled = true;
            btnCreateSubject.Enabled = false;
            btnDeleteSubject.Enabled = true;

            int id = (int)dgwSubjects.Rows[e.RowIndex].Cells[0].Value;
            selectedSubject = db.Subjects.Find(id);
            txtSubjectname.Text = selectedSubject.Name; selectedSubject = db.Subjects.Find(id);

            
        }




        private void btnEditSubject_Click(object sender, EventArgs e)
        {
            string newSubjectName = txtSubjectname.Text.Trim();

            if (String.IsNullOrEmpty(newSubjectName))
            {
                MessageBox.Show("Please edit subject name correctly", "Edit Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selectedSubject.Name = newSubjectName;
            MessageBox.Show($"Subject name edited successfully", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtSubjectname.Text = "";
            btnCreateSubject.Enabled = true;
            btnEditSubject.Enabled = false;
            btnDeleteSubject.Enabled = false;
            db.SaveChanges();
            updateSubjectsDataGrid();
        }



        
        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            string selectedSubjectName = selectedSubject.Name;

            DialogResult result =
                       MessageBox.Show($"Are you sure to delete {selectedSubjectName}?",
                    "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                selectedSubject.Status = false;
            }
            MessageBox.Show($"Subject: {selectedSubjectName} removed successfully from your system", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtSubjectname.Text = "";
            btnCreateSubject.Enabled = true;
            btnEditSubject.Enabled = false;
            btnDeleteSubject.Enabled = false;
            db.SaveChanges();
            updateSubjectsDataGrid();
        }
    }
}
