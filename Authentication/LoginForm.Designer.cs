namespace Authentication
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            emailTxt = new Label();
            passwordTxt = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            txtEmailErr = new Label();
            txtPasswordErr = new Label();
            SuspendLayout();
            // 
            // emailTxt
            // 
            emailTxt.AutoSize = true;
            emailTxt.Location = new Point(822, 214);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(46, 20);
            emailTxt.TabIndex = 0;
            emailTxt.Text = "Email";
            emailTxt.Click += emailTxt_Click;
            // 
            // passwordTxt
            // 
            passwordTxt.AutoSize = true;
            passwordTxt.Location = new Point(822, 359);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(70, 20);
            passwordTxt.TabIndex = 1;
            passwordTxt.Text = "Password";
            passwordTxt.Click += passwordTxt_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(939, 211);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 27);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(939, 356);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(180, 27);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(1025, 510);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtEmailErr
            // 
            txtEmailErr.AutoSize = true;
            txtEmailErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmailErr.ForeColor = Color.Red;
            txtEmailErr.Location = new Point(939, 255);
            txtEmailErr.Name = "txtEmailErr";
            txtEmailErr.Size = new Size(52, 17);
            txtEmailErr.TabIndex = 5;
            txtEmailErr.Text = "label1";
            txtEmailErr.Click += emailErrTxt_Click;
            // 
            // txtPasswordErr
            // 
            txtPasswordErr.AutoSize = true;
            txtPasswordErr.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPasswordErr.ForeColor = Color.Red;
            txtPasswordErr.Location = new Point(939, 419);
            txtPasswordErr.Name = "txtPasswordErr";
            txtPasswordErr.Size = new Size(52, 17);
            txtPasswordErr.TabIndex = 6;
            txtPasswordErr.Text = "label2";
            txtPasswordErr.Click += passwordErrTxt_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(txtPasswordErr);
            Controls.Add(txtEmailErr);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(passwordTxt);
            Controls.Add(emailTxt);
            Name = "LoginForm";
            Text = "LoginForm";
            FormClosed += LoginForm_FormClosed;
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label emailTxt;
        private Label passwordTxt;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label txtEmailErr;
        private Label txtPasswordErr;
    }
}