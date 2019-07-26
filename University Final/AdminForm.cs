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
    public partial class AdminForm : Form
    {
        private readonly UniversityEntities db;
        public AdminForm()
        {
            InitializeComponent();
            db = new UniversityEntities();
        }
        
        

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {

            AddTeacher addTeacher = new AddTeacher();
            addTeacher.ShowDialog();

        }

        private void btnAddgroup_Click(object sender, EventArgs e)
        {
            AddGroup addgroup = new AddGroup();
            addgroup.ShowDialog();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
        }

        private void btnAddsubject_Click(object sender, EventArgs e)
        {
            AddSubject addSubject = new AddSubject();
            addSubject.ShowDialog();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            AddClass addClass = new AddClass();
            addClass.ShowDialog();
        }
    }
}
