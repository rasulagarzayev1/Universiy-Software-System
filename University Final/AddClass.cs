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
    public partial class AddClass : Form
    {
        private readonly UniversityEntities db;
        STG selectedSTG;
        public AddClass()
        {
            InitializeComponent();
            db = new UniversityEntities();
        }
        void updateClassesDataGrid()
        {
            dgwClasses.DataSource = db.STGs.Select(s => new
            {
               ID =s.ID,
               Subject = s.Subject.Name,
               Teacher = s.Teacher.Firstname + " " + s.Teacher.Lastname,
               Group = s.Group.Name
            }).ToList();
        }
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            Comboitem subject = cmbSubjects.SelectedItem as Comboitem;
            Comboitem teacher = cmbTeachers.SelectedItem as Comboitem;
            Comboitem group = cmbGroups.SelectedItem as Comboitem;

            STG stg = db.STGs.FirstOrDefault(s => s.SubjectID == subject.Value 
            && s.GroupID == group.Value);

            if (stg!=null)
            {
                MessageBox.Show($"Class with this properties has already exists", "Creation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            STG newstg = new STG
            {
                
                SubjectID = subject.Value,
                TeacherID = teacher.Value,
                GroupID = group.Value
            };

            db.STGs.Add(newstg);
            db.SaveChanges();
            updateClassesDataGrid();
            MessageBox.Show($"Class created successfully","Creation Success",
                MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void AddClass_Load(object sender, EventArgs e)
        {
            cmbSubjects.DataSource = db.Subjects.Where(s=>s.Status==true).Select(s => new Comboitem
            {
                Text = s.Name,
                Value = s.ID
            }).ToList();
            cmbTeachers.DataSource = db.Teachers.Where(t => t.Status == true).Select(t => new Comboitem
            {
                Text = t.Firstname + " " + t.Lastname,
                Value = t.ID
            }).ToList();
            cmbGroups.DataSource = db.Groups.Where(g => g.Status == true).Select(g => new Comboitem
            {
                Text = g.Name,
                Value = g.ID
            }).ToList();
            updateClassesDataGrid();
        }

        //private void dgwClasses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    btnEditClass.Enabled = true;
        //    btnAddClass.Enabled = false;

        //    int id = (int)dgwClasses.Rows[e.RowIndex].Cells[0].Value;
        //    selectedSTG = db.STGs.Find(id);
        //    cmbSubjects.SelectedItem = selectedSTG.Subject.Name;
        //    cmbTeachers.SelectedItem = selectedSTG.Teacher.Firstname + " " + selectedSTG.Teacher.Lastname;
        //    cmbGroups.SelectedItem = selectedSTG.Group.Name;

        //}

        //private void btnEditClass_Click(object sender, EventArgs e)
        //{
        //    Comboitem newSubjectname = cmbSubjects.SelectedItem as Comboitem;
        //    Comboitem newTeachername = cmbTeachers.SelectedItem as Comboitem;
        //    Comboitem newGroupname = cmbGroups.SelectedItem as Comboitem;
        //    STG stg = db.STGs.FirstOrDefault(s => s.SubjectID == newSubjectname.Value
        //   && s.GroupID == newGroupname.Value);

        //    if (stg != null)
        //    {
        //        MessageBox.Show($"Class with this properties has already exists", "Creation Error",
        //        MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    string teacherFullname = selectedSTG.Teacher.Firstname + " " + selectedSTG.Teacher.Lastname;
        //    selectedSTG.Subject.Name = newSubjectname.Text;
        //    teacherFullname = newTeachername.Text;
        //    selectedSTG.Group.Name = newGroupname.Text;


        //    MessageBox.Show($"Class edited successfully", "Success",
        //                   MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    db.SaveChanges();
        //    updateClassesDataGrid();
        //    btnAddClass.Enabled = true;
        //    btnEditClass.Enabled = false;

        //}
    }
}
