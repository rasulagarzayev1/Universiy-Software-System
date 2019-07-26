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
    public partial class Form1 : Form
    {

    private readonly UniversityEntities db;
        public Form1()
        {
            InitializeComponent();
            db = new UniversityEntities();
        }

        private void tnLogin_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(txtIdentifacator.Text);
            string password = txtPassword.Text;
            bool asAdmin = rbAdmin.Checked;
            bool asTeacher = rbTeacher.Checked;
            bool asStudent = rbStudent.Checked;

            if (asAdmin)
            {

                Admin admin = db.Admins.FirstOrDefault(a => a.Identifikator == userID);

                if (admin != null)
                {
                    if (Extension.CheckPassword(password,admin.Password))
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please enter password correctly", "Login Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter User ID correctly", "Login Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else if (asTeacher)
            {
                Teacher teacher = db.Teachers.FirstOrDefault(s => s.Identifikator == userID && s.Status ==true);

                if (teacher != null)
                {
                    if (Extension.CheckPassword(password, teacher.Password))
                    {
                        TeacherForm teacherForm = new TeacherForm(userID);
                        teacherForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please enter password correctly", "Login Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter User ID correctly", "Login Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(asStudent)
            {
                Student student = db.Students.FirstOrDefault(s => s.Identifikator == userID && s.Status==true);

                if (student != null)
                {
                    if (Extension.CheckPassword(password, student.Password))
                    {
                        StudentForm studentForm = new StudentForm(userID);
                        studentForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please enter password correctly", "Login Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter User ID correctly", "Login Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        
    }
}
