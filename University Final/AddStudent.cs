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
    public partial class AddStudent : Form
    {
        private readonly UniversityEntities db;
        Student selectedStudent;
        public AddStudent()
        {
            InitializeComponent();
            db = new UniversityEntities();
        }
        void updateStudentsDataGrid()
        {
            dgwStudents.DataSource = db.Students.Where(s => s.Status == true).Select(s => new
            {
                s.ID,
                s.Firstname,
                s.Lastname,
                s.Identifikator
            }).ToList();
        }
        

        private void AddStudent_Load(object sender, EventArgs e)
        {
            cmbGroups.DataSource = db.Groups.Select(g => new Comboitem
            {
                Text = g.Name,
                Value = g.ID
            }).ToList();
            updateStudentsDataGrid();

            dgwStudents.Columns[0].Visible = false;
        }

        private void btnCreateStudent_Click_1(object sender, EventArgs e)
        {
            string firstname = txtFirstname.Text;
            string lastname = txtLastname.Text;
            DateTime birthdate = dtBirthdate.Value;
            int userID = (int)nmUserID.Value;
            string password = txtPAssword.Text;
            Comboitem groupName = cmbGroups.SelectedItem as Comboitem;

            Student student = db.Students.FirstOrDefault(s => s.Identifikator == userID);

            if (student != null)
            {
                MessageBox.Show("Student with this User ID is already exists", "Creation Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(firstname) ||
                string.IsNullOrEmpty(lastname)
                || string.IsNullOrEmpty(password) ||
                userID < 100000)
            {
                MessageBox.Show("Please fill inputs correctly", "Creation Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Student newStudent = new Student
            {
                Firstname = firstname,
                Lastname = lastname,
                Birthdate = birthdate,
                Identifikator = userID,
                Password = Extension.HashPassword(password),
                Status = true,
                GroupID = groupName.Value

            };
            db.Students.Add(newStudent);
            db.SaveChanges();
            txtFirstname.Clear();
            txtLastname.Clear();
            txtPAssword.Clear();
            nmUserID.Value = 100000;
            dtBirthdate.Value = dtBirthdate.MaxDate;

            MessageBox.Show($"Student {firstname} {lastname} created successfully!", "Creation Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            updateStudentsDataGrid();
        }

       

        private void dgwStudents_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEditStudent.Enabled = true;
            btnCreateStudent.Enabled = false;
            btnDeleteStudent.Enabled = true;

            int id = (int)dgwStudents.Rows[e.RowIndex].Cells[0].Value;
            selectedStudent = db.Students.Find(id);
            txtFirstname.Text = selectedStudent.Firstname;
            txtLastname.Text = selectedStudent.Lastname;
            dtBirthdate.Value = (DateTime)selectedStudent.Birthdate;
            cmbGroups.SelectedItem = selectedStudent.Group.Name;

            selectedStudent = db.Students.Find(id);
            

        }


        private void btnEditStudent_Click(object sender, EventArgs e)
        {

            string newStudentName = txtFirstname.Text.Trim();
            string newStudentSurname = txtLastname.Text.Trim();
            string newPassword = txtPAssword.Text.Trim();
            DateTime newBirthdate = dtBirthdate.Value;
            Comboitem newGroup = cmbGroups.SelectedItem as Comboitem;



            
            if (String.IsNullOrEmpty(newStudentName) ||
                String.IsNullOrEmpty(newStudentSurname)||
                String.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please edit inputs correctly", "Edit Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selectedStudent.Firstname = newStudentName;
            selectedStudent.Lastname = newStudentSurname;
            selectedStudent.Password = Extension.HashPassword(newPassword);
            selectedStudent.Birthdate = newBirthdate;
            selectedStudent.Group.ID = newGroup.Value;

            MessageBox.Show($"Student edited successfully", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.SaveChanges();
            updateStudentsDataGrid();
            txtFirstname.Text = txtLastname.Text = txtPAssword.Text = "";
            dtBirthdate.Value = dtBirthdate.MaxDate;
            btnCreateStudent.Enabled = true;
            btnEditStudent.Enabled = false;
            btnDeleteStudent.Enabled = false;
        }

        

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            string selectedStudentName = selectedStudent.Firstname + " " + selectedStudent.Lastname;

            DialogResult result =
                       MessageBox.Show($"Are you sure to delete {selectedStudentName}?",
                    "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                selectedStudent.Status = false;
                MessageBox.Show($"Student {selectedStudentName} removed successfully from your system", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFirstname.Text = txtLastname.Text = txtPAssword.Text = "";
                dtBirthdate.Value = dtBirthdate.MaxDate;
                db.SaveChanges();
                updateStudentsDataGrid();
                txtFirstname.Text = txtLastname.Text = txtPAssword.Text = "";
                dtBirthdate.Value = dtBirthdate.MaxDate;
                btnCreateStudent.Enabled = true;
                btnEditStudent.Enabled = false;
                btnDeleteStudent.Enabled = false;
            }

        }
    }
}
