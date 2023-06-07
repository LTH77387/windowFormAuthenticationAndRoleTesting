namespace Authentication
{
    partial class HomeForm
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
            roleTxt = new Label();
            SuspendLayout();
            // 
            // roleTxt
            // 
            roleTxt.AutoSize = true;
            roleTxt.Font = new Font("Cambria", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            roleTxt.Location = new Point(168, 55);
            roleTxt.Name = "roleTxt";
            roleTxt.Size = new Size(93, 33);
            roleTxt.TabIndex = 0;
            roleTxt.Text = "label1";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(roleTxt);
            Name = "HomeForm";
            Text = "HomeForm";
            FormClosed += HomeForm_FormClosed;
            Load += HomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label roleTxt;
    }
}