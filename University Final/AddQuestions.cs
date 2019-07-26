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
    public partial class AddQuestions : Form
    {
        private readonly UniversityEntities db;
        int myUserId;
        Question selectedQuestion; 
        public AddQuestions(string userID)
        {
            InitializeComponent();
            db = new UniversityEntities();
            myUserId = Convert.ToInt32(userID);
        }


        void updateQuestionsDataGrid()
        {
            dgwQuestions.DataSource = db.Questions.Where(q => q.Status == true).Select(q => new
            {
                q.ID,
                Content = q.Content,
                VariantA = q.VarianA,
                VariantB = q.VariantB,
                VariantC = q.VarianC,
                Correct = q.CorrectVariant,
                Subject = q.Subject.Name
            }).ToList();

            dgwQuestions.Columns[0].Visible = false;
        }



        private void AddQuestions_Load(object sender, EventArgs e)
        {
            cmbSubjects.DataSource = db.STGs.Where(s => s.Teacher.Identifikator == myUserId && s.Subject.Status == true).Select(s => new Comboitem {
                Text = s.Subject.Name,
                Value = s.Subject.ID
            }).Distinct().ToList();
            updateQuestionsDataGrid();
        }



        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            string questionContent = txtQuestionContent.Text.Trim();
            string variantA = txtVariantA.Text.Trim();
            string variantB = txtVariantB.Text.Trim();
            string variantC = txtVariantC.Text.Trim();
            string correctVariant = "";
            bool correctA = rbCorrectA.Checked;
            bool correctB = rbCorrectB.Checked;
            bool correctC = rbCorrectC.Checked;

            Comboitem subject = cmbSubjects.SelectedItem as Comboitem;

            if (String.IsNullOrEmpty(questionContent)||
                String.IsNullOrEmpty(variantA)||
                String.IsNullOrEmpty(variantB)||
                String.IsNullOrEmpty(variantC))
            {
                MessageBox.Show("All inputs must be filled","Creation Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (!(correctA || correctB || correctC))
            {
                MessageBox.Show("Please choose correct variant", "Creation Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Question question = db.Questions.FirstOrDefault(q => q.Content.ToLower() == questionContent);

            if (question != null)
            {
                MessageBox.Show("This question has already exists,Please create new one", "Creation Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (subject==null)
            {
                MessageBox.Show("Please choose subject", "Creation Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (correctA)
            {
                correctVariant = variantA;
            }
            else if(correctB)
            {
                correctVariant = variantB;
            }
            else if (correctC)
            {
                correctVariant = variantC;
            }

            Question newQuestion = new Question
            {
                Content = questionContent,
                VarianA = variantA,
                VariantB = variantB,
                VarianC = variantC,
                CorrectVariant = correctVariant,
                Status = true,
                SubjectID = subject.Value
            };
            db.Questions.Add(newQuestion);
            db.SaveChanges();
            updateQuestionsDataGrid();
            MessageBox.Show("New Question created successfully", "Success",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtQuestionContent.Text = txtVariantA.Text = txtVariantB.Text = txtVariantC.Text = "";
            rbCorrectA.Checked = rbCorrectB.Checked = rbCorrectC.Checked = false;

        }


        
        private void dgwQuestions_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEditQuestion.Enabled = true;
            btnAddQuestion.Enabled = false;
            btnDeleteQuestion.Enabled = true;
            int id = (int)dgwQuestions.Rows[e.RowIndex].Cells[0].Value;
            selectedQuestion = db.Questions.Find(id);
            txtQuestionContent.Text = selectedQuestion.Content;
            txtVariantA.Text = selectedQuestion.VarianA;
            txtVariantB.Text = selectedQuestion.VariantB;
            txtVariantC.Text = selectedQuestion.VarianC;
            cmbSubjects.SelectedItem = selectedQuestion.Subject;
            selectedQuestion = db.Questions.Find(id);

            
        }



        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            string newContent = txtQuestionContent.Text.Trim();
            string newVariantA = txtVariantA.Text.Trim();
            string newVariantB = txtVariantB.Text.Trim();
            string newVariantC = txtVariantC.Text.Trim();
            bool correctVariantA = rbCorrectA.Checked;
            bool correctVariantB = rbCorrectB.Checked;
            bool correctVariantC = rbCorrectC.Checked;
            string newCorrectVariant = "";
            Comboitem newSubject = cmbSubjects.SelectedItem as Comboitem;




            if (String.IsNullOrEmpty(newContent) ||
                String.IsNullOrEmpty(newVariantA) ||
                String.IsNullOrEmpty(newVariantB)||
                String.IsNullOrEmpty(newVariantC)||
                String.IsNullOrEmpty(newContent))
            {
                MessageBox.Show("Please edit inputs correctly", "Edit Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (correctVariantA)
            {
                newCorrectVariant = newVariantA;
            }
            else if (correctVariantB)
            {
                newCorrectVariant = newVariantB;
            }
            else if (correctVariantC)
            {
                newCorrectVariant = newVariantC;
            }
            else
            {
                MessageBox.Show("Please choose  correct variant", "Edit Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selectedQuestion.Content = newContent;
            selectedQuestion.VarianA = newVariantA;
            selectedQuestion.VariantB = newVariantB;
            selectedQuestion.VarianC = newVariantC;
            selectedQuestion.CorrectVariant = newCorrectVariant;
            selectedQuestion.SubjectID = newSubject.Value;

            MessageBox.Show($"Student edited successfully", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.SaveChanges();
            updateQuestionsDataGrid();
            txtQuestionContent.Text = txtVariantA.Text = txtVariantB.Text = txtVariantC.Text = "";
            btnAddQuestion.Enabled = true;
            btnEditQuestion.Enabled = false;
        }

        

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            DialogResult result =
                       MessageBox.Show($"Are you sure to delete that question?",
                    "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                selectedQuestion.Status = false;
                db.SaveChanges();
                MessageBox.Show($"Question removed successfully from your system", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuestionContent.Text = txtVariantA.Text = txtVariantB.Text = txtVariantC.Text = "";
                btnAddQuestion.Enabled = true;
                btnEditQuestion.Enabled = false;
                updateQuestionsDataGrid();
            }
        }
    }
}
