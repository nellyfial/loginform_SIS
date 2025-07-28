using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace loginform_SIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.textBox1.Text;
            string password = this.textBox2.Text;
            textBox2.UseSystemPasswordChar = true;

            string connectionString = "Data Source=LAB4-PC28\\SQLEXPRESS;Initial Catalog=SIS;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT role_id FROM users WHERE username = @username AND password = @password";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int role_Id = Convert.ToInt32(result);
                        switch (role_Id)
                        {
                            case 1:
                                admin adminform = new admin(username);
                                adminform.Show();
                                this.Hide();
                                break;
                            case 2:
                                student studentform = new student(username);
                                studentform.Show();
                                this.Hide();
                                break;
                            case 3:
                                teacher teacherform = new teacher(username);
                                teacherform.Show();
                                this.Hide();
                                break;
                            default:
                                MessageBox.Show("Unknown User:(");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
