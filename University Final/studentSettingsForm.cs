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
    public partial class studentSettingsForm : Form
    {

        private readonly UniversityEntities db;
        int UserId;
        public studentSettingsForm(string userID)
        {
            InitializeComponent();
            db = new UniversityEntities();
            UserId = Convert.ToInt32(userID);
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            Student selectedStudent = db.Students.FirstOrDefault(s => s.Identifikator == UserId);
            string newStudentName = txtFirstname.Text.Trim();
            string newStudenttSurname = txtLastname.Text.Trim();
            string newPassword = txtPassword.Text.Trim();
            DateTime newBirthdate = dtBirthdate.Value;




            if (String.IsNullOrEmpty(newStudentName) ||
                String.IsNullOrEmpty(newStudenttSurname) ||
                String.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please edit inputs correctly", "Edit Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selectedStudent.Firstname = newStudentName;
            selectedStudent.Lastname = newStudenttSurname;
            selectedStudent.Password = Extension.HashPassword(newPassword);
            selectedStudent.Birthdate = newBirthdate;

            MessageBox.Show($"Student edited successfully", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.SaveChanges();
            txtFirstname.Text = txtLastname.Text = txtPassword.Text = "";
            dtBirthdate.Value = dtBirthdate.MaxDate;
        }

        private void studentSettingsForm_Load(object sender, EventArgs e)
        {
            Student student = db.Students.FirstOrDefault(s => s.Identifikator == UserId);
            txtFirstname.Text = student.Firstname;
            txtLastname.Text = student.Lastname;
            dtBirthdate.Value = student.Birthdate.Value;
        }
    }
}
