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
using University_Final.Extensions;
namespace University_Final
{
    public partial class AddTeacher : Form
    {
        private readonly UniversityEntities db;
        Teacher selectedTeacher;
        public AddTeacher()
        {
            InitializeComponent();
            db = new UniversityEntities();
        }

        void updateTeachersDataGrid()
        {
            dgwTeachers.DataSource = db.Teachers.Where(t => t.Status == true).Select(t => new
            {
                t.ID,
                t.Firstname,
                t.Lastname,
                t.Identifikator
            }).ToList();

            dgwTeachers.Columns[0].Visible = false;
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {
            updateTeachersDataGrid();
        }


        private void btnCreateTeacher_Click(object sender, EventArgs e)
        {
          
                string firstname = txtFirstname.Text;
                string lastname = txtLastname.Text;
                DateTime birthdate = dtBirthdate.Value;
                int userID = (int)nmUserID.Value;
                string password = txtPAssword.Text;

                Teacher teacher = db.Teachers.FirstOrDefault(t => t.Identifikator == userID);

                if (teacher != null)
                {
                    MessageBox.Show("Teacher with this User ID is already exists", "Creation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(firstname) ||
                    string.IsNullOrEmpty(lastname)
                    || string.IsNullOrEmpty(password) ||
                    userID < 1000)
                {
                    MessageBox.Show("Please fill inputs correctly", "Creation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Teacher newTeacher = new Teacher
                {
                    Firstname = firstname,
                    Lastname = lastname,
                    Birthdate = birthdate,
                    Identifikator = userID,
                    Password = Extension.HashPassword(password),
                    Status = true
                };
                db.Teachers.Add(newTeacher);
                db.SaveChanges();
                txtFirstname.Clear();
                txtLastname.Clear();
                txtPAssword.Clear();
                nmUserID.Value = 1000;
                dtBirthdate.Value = dtBirthdate.MaxDate;

                MessageBox.Show($"Teacher {firstname} {lastname} created successfully!", "Creation Success",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateTeachersDataGrid();
            
        }

        
        private void dgwTeachers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEditTeacher.Enabled = true;
            btnCreateTeacher.Enabled = false;
            btnDeleteTeacher.Enabled = true;


            int id = (int)dgwTeachers.Rows[e.RowIndex].Cells[0].Value;
            selectedTeacher = db.Teachers.Find(id);
            txtFirstname.Text = selectedTeacher.Firstname;
            txtLastname.Text = selectedTeacher.Lastname;
            dtBirthdate.Value = (DateTime)selectedTeacher.Birthdate;
            selectedTeacher = db.Teachers.Find(id);
            

        }



        private void btnEditTeacher_Click(object sender, EventArgs e)
        {
            string newTeacherName = txtFirstname.Text.Trim();
            string newTeachertSurname = txtLastname.Text.Trim();
            string newPassword = txtPAssword.Text.Trim();
            DateTime newBirthdate = dtBirthdate.Value;




            if (String.IsNullOrEmpty(newTeacherName) ||
                String.IsNullOrEmpty(newTeachertSurname) ||
                String.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please edit inputs correctly", "Edit Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selectedTeacher.Firstname = newTeacherName;
            selectedTeacher.Lastname = newTeachertSurname;
            selectedTeacher.Password = Extension.HashPassword(newPassword);
            selectedTeacher.Birthdate = newBirthdate;

            MessageBox.Show($"Teacher edited successfully", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.SaveChanges();
            updateTeachersDataGrid();
            txtFirstname.Text = txtLastname.Text = txtPAssword.Text = "";
            dtBirthdate.Value = dtBirthdate.MaxDate;
            btnCreateTeacher.Enabled = true;
            btnEditTeacher.Enabled = false;
            btnDeleteTeacher.Enabled = false;
        }

        

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            string selectedTeacherName = selectedTeacher.Firstname + " " + selectedTeacher.Lastname;

            DialogResult result =
                       MessageBox.Show($"Are you sure to delete {selectedTeacherName}?",
                    "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                selectedTeacher.Status = false;
                MessageBox.Show($"Teacher {selectedTeacherName} removed successfully from your system", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFirstname.Text = txtLastname.Text = txtPAssword.Text = "";
                dtBirthdate.Value = dtBirthdate.MaxDate;
                btnCreateTeacher.Enabled = true;
                btnEditTeacher.Enabled = false;
                btnDeleteTeacher.Enabled = false;
                db.SaveChanges();
                updateTeachersDataGrid();
            }
        }


    }
}
