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
    public partial class StudentForm : Form
    {
        private readonly UniversityEntities db;
        public StudentForm(int userId)
        {
            InitializeComponent();
            db = new UniversityEntities();
            lblUserID.Text = (userId).ToString();
        }

        private void btnYourProfile_Click(object sender, EventArgs e)
        {
            StudentProfile studentProfile = new StudentProfile(lblUserID.Text);
            studentProfile.ShowDialog();
        }

        private void btnProfileSettings_Click(object sender, EventArgs e)
        {
            studentSettingsForm studentSettingsForm = new studentSettingsForm(lblUserID.Text);
            studentSettingsForm.ShowDialog();
        }
    }
}
