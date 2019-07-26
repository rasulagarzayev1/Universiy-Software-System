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
    public partial class Exam : Form
    {
        private readonly UniversityEntities db;
        int userId;
        Comboitem mySubject;
        public Exam(int userID,Comboitem subject)
        {
            InitializeComponent();
            db = new UniversityEntities();
            userId = userID;
            mySubject = subject;
        }

        private void Exam_Load(object sender, EventArgs e)
        {
            int panelCount = 0;
            int y = -165;
            foreach (var question in db.Questions.Where(q => q.SubjectID == mySubject.Value).ToList()) 
            {

                panelCount++;
                y += 165;
                
                Panel newPanel = new Panel();
                newPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                newPanel.Location = new Point(12, y);
                newPanel.Name = "panel1";
                newPanel.Size = new Size(1149, 139);

                this.Controls.Add(newPanel);



                Label newLabel = new Label();
                newLabel.Dock = DockStyle.Top;
                newLabel.Font = new Font("Franklin Gothic Demi", 13.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                newLabel.Location = new Point(100, 100);
                newLabel.Name = "label1";
                newLabel.Size = new Size(1182, 26);
                newLabel.Text = question.Content;

                newPanel.Controls.Add(newLabel);

                RadioButton newRbA = new RadioButton();
                newRbA.AutoSize = true;
                newRbA.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                newRbA.Location = new Point(5, 110);
                newRbA.Name = "radioButton1";
                newRbA.Size = new Size(145, 29);
                newRbA.TabIndex = 1;
                newRbA.TabStop = true;
                newRbA.Text = question.VarianA;
                newRbA.UseVisualStyleBackColor = true;

                newPanel.Controls.Add(newRbA);


                RadioButton newRbB = new RadioButton();
                newRbB.AutoSize = true;
                newRbB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                newRbB.Location = new System.Drawing.Point(420, 110);
                newRbB.Name = "radioButton2";
                newRbB.Size = new System.Drawing.Size(145, 29);
                newRbB.TabIndex = 2;
                newRbB.TabStop = true;
                newRbB.Text = question.VariantB;
                newRbB.UseVisualStyleBackColor = true;

                newPanel.Controls.Add(newRbB);


                RadioButton newRbC = new RadioButton();
                newRbC.AutoSize = true;
                newRbC.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                newRbC.Location = new System.Drawing.Point(795, 110);
                newRbC.Name = "radioButton3";
                newRbC.Size = new System.Drawing.Size(145, 29);
                newRbC.TabIndex = 3;
                newRbC.TabStop = true;
                newRbC.Text = question.VarianC;
                newRbC.UseVisualStyleBackColor = true;

                newPanel.Controls.Add(newRbC);

                
            }
        }

        private void btnFinishExam_Click(object sender, EventArgs e)
        {
            int examPoint = 0;
            foreach (Control myPanel in Controls)
            {
                if (myPanel is Panel)
                {
                    foreach (Control myLabel in ((Panel)myPanel).Controls)
                    {
                        if (myLabel is Label)
                        {
                            Question myQuestion = db.Questions.FirstOrDefault(q => q.Content == ((Label)myLabel).Text);
                            foreach (Control myRb in ((Panel)myPanel).Controls)
                            {
                                if (myRb is RadioButton)
                                {
                                    if (((RadioButton)myRb).Checked && myQuestion.CorrectVariant == myRb.Text)
                                    {
                                        examPoint += 10;
                                    }
                                    else
                                    {
                                        examPoint += 0;
                                    }
                                }
                            }
                        }
                    }
                }

            }
            int myAvarage = (int)db.BeforeExamGrades.Where(b => b.Student.Identifikator == userId && b.SubjectID == mySubject.Value).Select(g => g.DailyPoint).Average();
            Student student = db.Students.FirstOrDefault(s => s.Identifikator == userId);
            int gpa = myAvarage * 5;

            Model.Exam newExam = new Model.Exam()
            {
                StudentID = student.ID,
                SubjectID = mySubject.Value,
                EnterenceGrade = gpa,
                ExamGrade = examPoint,
                FinalGrade = examPoint + gpa
            };

            db.Exams.Add(newExam);
            db.SaveChanges();

           
            if (examPoint>17 && gpa + examPoint>50)
            {
                MessageBox.Show($"You pass the exam. Your exam point is {examPoint}, and final point is {gpa+examPoint}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (examPoint < 17 || gpa + examPoint<50)
            {
                if (examPoint < 17 && examPoint + gpa > 50)
                {
                    MessageBox.Show($"You cannot pass the exam. Your exam point is {examPoint}, and final point is {gpa + examPoint},Exam point must be greater than 17", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (gpa + examPoint < 50 && examPoint > 17) 
                {
                    MessageBox.Show($"You cannot pass the exam. Your exam point is {examPoint}, and final point is {gpa + examPoint},Final point must be greater than 50", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show($"You cannot pass the exam. Your exam point is {examPoint}, and final point is {gpa + examPoint}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            Close();

        }
    }
}
