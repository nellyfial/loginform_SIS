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
    public partial class teacher : Form
    {
        private string userTeacher;
        public teacher(string teacher)
        {
            InitializeComponent();
            this.userTeacher = teacher;
        }

        private void teacher_Load(object sender, EventArgs e)
        {
            lblWelcomeTeacher.Text = $"Hello! Welcome {userTeacher}!";
        }
    }
}
