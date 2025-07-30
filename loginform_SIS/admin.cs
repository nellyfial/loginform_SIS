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
    public partial class admin : Form
    {
        private string userAdmin;
        public admin(string admin)
        {
            InitializeComponent();
            this.userAdmin = admin;
        }

        private void admin_Load(object sender, EventArgs e)
        {
            lblWelcomeAdmin.Text = $"Welcome {userAdmin}!";
        }
    }
}
