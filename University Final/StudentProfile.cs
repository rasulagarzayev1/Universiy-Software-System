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
    public partial class StudentProfile : Form
    {
        private readonly UniversityEntities db;
        int UserId;
        Comboitem subject;
        List<int> gradeList;
        public StudentProfile(string userID)
        {
            InitializeComponent();
            db = new UniversityEntities();
            UserId = Convert.ToInt32(userID);
            gradeList = new List<int>();

        }

        private void StudentProfile_Load(object sender, EventArgs e)
        {
            Student student = db.Students.FirstOrDefault(s => s.Identifikator == UserId);
            cmbSubjects.DataSource = db.STGs.Where(s => s.Subject.Status == true && s.GroupID == student.GroupID).Select(s => new Comboitem
            {
                Text = s.Subject.Name,
                Value = s.Subject.ID
            }).Distinct().ToList();

            lblStudentInfo.Text = student.Firstname + " " + student.Lastname;
            dgwStudentPoint.DataSource = db.BeforeExamGrades.Where(s=>s.Student.Identifikator==UserId).Select(s => new
            {
                s.ID,
                Student = s.Student.Firstname + " " + s.Student.Lastname,
                s.Subject.Name,
                s.DailyPoint,
                s.PointDate,

            }).Distinct().ToList();

            dgwStudentPoint.Columns[0].Visible = false;
            
        }

        

        private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            int yourBeforeExamGrade = 0;
            int grade = 0;
            subject = cmbSubjects.SelectedItem as Comboitem;
            foreach (var item in db.BeforeExamGrades.Where(s => s.Student.Identifikator == UserId && s.SubjectID == subject.Value))
            {
                gradeList.Add((int)item.DailyPoint);
                grade = grade + (int)item.DailyPoint;
            }
            int gradeCount = gradeList.Count();

            if (gradeCount == 0)
            {
                lblCanPass.Text = "Your before exam grade is less than 17,So you can not enter the exam";
                this.lblCanPass.ForeColor = System.Drawing.Color.Red;
                return;
            }
            yourBeforeExamGrade = (grade / gradeCount) * 5;

            if (yourBeforeExamGrade < 17)
            {
                lblCanPass.Text = "Your before exam grade is less than 17,So you can not enter the exam";
                this.lblCanPass.ForeColor = System.Drawing.Color.Red;
            }
            else if (yourBeforeExamGrade > 17)
            {
                lblCanPass.Text = $"Your before exam grade is {yourBeforeExamGrade} , You can enter the exam.Good Luck";
                this.lblCanPass.ForeColor = System.Drawing.Color.Green;
            }
            grade = 0;
            yourBeforeExamGrade = 0;
            gradeCount = 0;
            gradeList.Clear();
        }
        private void btnStartExam_Click(object sender, EventArgs e)
        {
            Exam exam = new Exam(UserId,subject);
            exam.ShowDialog();

           
            
        }
       
    }
}
