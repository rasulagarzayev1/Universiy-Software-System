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
    public partial class StudentPointForm : Form
    {
        private readonly UniversityEntities db;
        int myUserID;
        public StudentPointForm(string UserID)
        {
            InitializeComponent();
            db = new UniversityEntities();
            myUserID = Convert.ToInt32(UserID);
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            int point = (int)nmPoint.Value;
            Comboitem selectedStudentName = cmbStudents.SelectedItem as Comboitem;
            Comboitem selectedSubjectName = cmbSubjects.SelectedItem as Comboitem;
            DateTime pointDate = dtPointDate.Value;

            BeforeExamGrade newGrade = new BeforeExamGrade
            {
                DailyPoint = point,
                PointDate = pointDate,
                StudentID = selectedStudentName.Value,
                SubjectID = selectedSubjectName.Value
            };
            db.BeforeExamGrades.Add(newGrade);
            db.SaveChanges();
            MessageBox.Show($"Point created successfully!", "Creation Success",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            nmPoint.Value = nmPoint.Minimum;
            
        }


        private void StudentPointForm_Load(object sender, EventArgs e)
        {
            cmbSubjects.DataSource = db.STGs.Where(s => s.Teacher.Identifikator == myUserID && s.Subject.Status==true).Select(s => new Comboitem
            {
                Text = s.Subject.Name,
                Value = s.Subject.ID
            }).Distinct().ToList();

            Teacher teacher = db.Teachers.FirstOrDefault(t => t.Identifikator == myUserID);

            lblTeacher.Text = "Teacher :" + " " + teacher.Firstname + " " + teacher.Lastname;

            dgwPoints.DataSource = db.BeforeExamGrades.Select(s => new
            {
                s.ID,
                Student = s.Student.Firstname + " " + s.Student.Lastname,
                s.Subject.Name,
                s.DailyPoint,
                s.PointDate,

            }).Distinct().ToList();

            dgwPoints.Columns[0].Visible = false;
        }

        private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comboitem selectedSubject = cmbSubjects.SelectedItem as Comboitem;
            cmbGroups.DataSource = db.STGs.Where(s => s.Teacher.Identifikator == myUserID && s.SubjectID == selectedSubject.Value && s.Teacher.Status==true).Select(s => new Comboitem
            {
                Text = s.Group.Name,
                Value = s.Group.ID
            }).Distinct().ToList();
        }

        private void cmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comboitem selectedGroup = cmbGroups.SelectedItem as Comboitem;
            cmbStudents.DataSource = db.Students.Where(s => s.GroupID == selectedGroup.Value && s.Status==true).Select(s => new Comboitem
            {
                Text = s.Firstname + " " + s.Lastname,
                Value = s.Group.ID
            }).ToList();
        }
    }
}
