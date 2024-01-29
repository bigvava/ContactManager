namespace ContactManager
{
    partial class LoginForm
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
            btnLogin = new Button();
            panel1 = new Panel();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(51, 132);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(241, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "შესვლა";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(103, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 194);
            panel1.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(51, 88);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "პაროლი";
            txtPassword.Size = new Size(241, 27);
            txtPassword.TabIndex = 4;
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(51, 40);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "სახელი";
            txtUserName.Size = new Size(241, 27);
            txtUserName.TabIndex = 3;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(558, 375);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "შესვლა";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnLogin;
        private Panel panel1;
        private TextBox txtUserName;
        private TextBox txtPassword;
    }
}
