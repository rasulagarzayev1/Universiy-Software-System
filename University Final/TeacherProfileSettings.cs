using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_Final.Model;
using University_Final.Extensions;

namespace University_Final
{
    public partial class TeacherProfileSettings : Form
    {
        private readonly UniversityEntities db;
        int UserId;
        public TeacherProfileSettings(string userID)
        {
            InitializeComponent();
             UserId = Convert.ToInt32(userID);
             db = new UniversityEntities();
           
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {

            Teacher selectedTeacher = db.Teachers.FirstOrDefault(t => t.Identifikator == UserId);
            string newTeacherName = txtFirstname.Text.Trim();
            string newTeachertSurname = txtLastname.Text.Trim();
            string newPassword = txtPassword.Text.Trim();
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
            txtFirstname.Text = txtLastname.Text = txtPassword.Text = "";
            dtBirthdate.Value = dtBirthdate.MaxDate;

        }

        private void TeacherProfileSettings_Load(object sender, EventArgs e)
        {
            Teacher teacher = db.Teachers.FirstOrDefault(t => t.Identifikator == UserId);

            txtFirstname.Text = teacher.Firstname;
            txtLastname.Text = teacher.Lastname;
            dtBirthdate.Value = teacher.Birthdate.Value;
        }
    }
}
