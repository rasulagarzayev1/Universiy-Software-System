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

namespace University_Final
{
    public partial class TeacherForm : Form
    {
        private readonly UniversityEntities db;
        public TeacherForm(int userID)
        {
            InitializeComponent();
            db = new UniversityEntities();
            lblUserID.Text = (userID).ToString();

        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            int userIdent =Convert.ToInt32(lblUserID.Text);
            Teacher teacher = db.Teachers.FirstOrDefault(t => t.Identifikator == userIdent);

            lblTeacher.Text = "Welcome"+ " " + teacher.Firstname + " " + teacher.Lastname;
        }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            TeacherProfileSettings userSettings = new TeacherProfileSettings(lblUserID.Text);
            userSettings.ShowDialog();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            StudentPointForm studentForm = new StudentPointForm(lblUserID.Text);
            studentForm.ShowDialog();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            AddQuestions addQuestions = new AddQuestions(lblUserID.Text);
            addQuestions.ShowDialog();
        }
    }
}
