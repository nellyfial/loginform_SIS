using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginform_SIS
{
    public partial class student : Form
    {
        private string userStudent;
        public student(string student)
        {
            InitializeComponent();
            this.userStudent = student;
        }

        private void student_Load(object sender, EventArgs e)
        {
            lblWelcomeStudent.Text = $"Welcome {userStudent}!";
        }
    }
}
