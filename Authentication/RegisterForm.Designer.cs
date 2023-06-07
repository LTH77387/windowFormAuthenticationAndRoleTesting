namespace Authentication
{
    partial class RegisterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            label1 = new Label();
            nameErrTxt = new Label();
            label3 = new Label();
            passwordErrTxt = new Label();
            emailErrtxt = new Label();
            label6 = new Label();
            label7 = new Label();
            btnRegister = new Button();
            emailTxt = new TextBox();
            nameTxt = new TextBox();
            passwordTxt = new TextBox();
            loginClicked = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(816, 60);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(292, 40);
            label1.TabIndex = 0;
            label1.Text = "Registration Form";
            label1.Click += label1_Click;
            // 
            // nameErrTxt
            // 
            nameErrTxt.AutoSize = true;
            nameErrTxt.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nameErrTxt.ForeColor = Color.Red;
            nameErrTxt.Location = new Point(942, 212);
            nameErrTxt.Name = "nameErrTxt";
            nameErrTxt.Size = new Size(166, 17);
            nameErrTxt.TabIndex = 1;
            nameErrTxt.Text = "Please fill out this field";
            nameErrTxt.Click += nameErrTxt_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(810, 295);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // passwordErrTxt
            // 
            passwordErrTxt.AutoSize = true;
            passwordErrTxt.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordErrTxt.ForeColor = Color.Red;
            passwordErrTxt.Location = new Point(942, 481);
            passwordErrTxt.Name = "passwordErrTxt";
            passwordErrTxt.Size = new Size(166, 17);
            passwordErrTxt.TabIndex = 3;
            passwordErrTxt.Text = "Please fill out this field";
            passwordErrTxt.Click += passwordErrTxt_Click;
            // 
            // emailErrtxt
            // 
            emailErrtxt.AutoSize = true;
            emailErrtxt.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            emailErrtxt.ForeColor = Color.Red;
            emailErrtxt.Location = new Point(942, 343);
            emailErrtxt.Name = "emailErrtxt";
            emailErrtxt.Size = new Size(166, 17);
            emailErrtxt.TabIndex = 4;
            emailErrtxt.Text = "Please fill out this field";
            emailErrtxt.Click += emailErrtxt_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(810, 174);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 5;
            label6.Text = "Name";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(810, 441);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 6;
            label7.Text = "Password";
            label7.Click += label7_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(1028, 561);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(942, 295);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(180, 27);
            emailTxt.TabIndex = 8;
            emailTxt.TextChanged += emailTxt_TextChanged;
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(942, 171);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(180, 27);
            nameTxt.TabIndex = 9;
            nameTxt.TextChanged += nameTxt_TextChanged;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(942, 438);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(180, 27);
            passwordTxt.TabIndex = 10;
            passwordTxt.TextChanged += passwordTxt_TextChanged;
            // 
            // loginClicked
            // 
            loginClicked.AutoSize = true;
            loginClicked.Location = new Point(816, 565);
            loginClicked.Name = "loginClicked";
            loginClicked.Size = new Size(178, 20);
            loginClicked.TabIndex = 11;
            loginClicked.TabStop = true;
            loginClicked.Text = "Already have an account?";
            loginClicked.LinkClicked += loginClicked_LinkClicked;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(loginClicked);
            Controls.Add(passwordTxt);
            Controls.Add(nameTxt);
            Controls.Add(emailTxt);
            Controls.Add(btnRegister);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(emailErrtxt);
            Controls.Add(passwordErrTxt);
            Controls.Add(label3);
            Controls.Add(nameErrTxt);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label nameErrTxt;
        private Label label3;
        private Label passwordErrTxt;
        private Label emailErrtxt;
        private Label label6;
        private Label label7;
        private Button btnRegister;
        private TextBox emailTxt;
        private TextBox nameTxt;
        private TextBox passwordTxt;
        private LinkLabel loginClicked;
    }
}