using System.Data.SqlClient;
namespace Authentication
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "")
            {
                nameErrTxt.Show();
            }
            if (emailTxt.Text == "")
            {
                emailErrtxt.Show();
            }
            if (passwordTxt.Text == "")
            {
                passwordErrTxt.Show();
            }

            // ok 
            if (nameTxt.Text != "" && emailTxt.Text != "" && passwordTxt.Text != "")
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\authentication.mdf;Integrated Security=True;Connect Timeout=30");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO [User] (Name,Email,Password) VALUES (@user_name,@email,@password)", conn);
                    cmd.Parameters.AddWithValue("@user_name", nameTxt.Text);
                    cmd.Parameters.AddWithValue("@email", emailTxt.Text);
                    cmd.Parameters.AddWithValue("@password", passwordTxt.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Registration Success!","Success Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            nameErrTxt.Hide();
            emailErrtxt.Hide();
            passwordErrTxt.Hide();
        }

        private void nameErrTxt_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void passwordErrTxt_Click(object sender, EventArgs e)
        {
        }

        private void emailErrtxt_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void loginClicked_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}