using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authentication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtEmailErr.Hide();
            txtPasswordErr.Hide();
        }

        private void emailErrTxt_Click(object sender, EventArgs e)
        {

        }

        private void passwordErrTxt_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void passwordTxt_Click(object sender, EventArgs e)
        {
        }

        private void emailTxt_Click(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmailErr.Text = "Please fill out this field.";
                txtEmailErr.Show();
            }
            if (txtPassword.Text == "")
            {
                txtPasswordErr.Text = "Please fill out this field.";
                txtPasswordErr.Show();
            }
            if (txtEmail.Text != "" && txtPassword.Text != "")
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\authentication.mdf;Integrated Security=True;Connect Timeout=30");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT User_ID FROM [User] WHERE Email=@email AND Password=@password", conn);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        int userID = Convert.ToInt32(dataTable.Rows[0]["User_ID"]);
                        HomeForm homeForm = new HomeForm(userID);
                        homeForm.Show();
                        this.Hide();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
