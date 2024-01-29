namespace ContactManager
{
    partial class UserAddForm
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            txtAddress = new TextBox();
            txtSite = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 260);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 29;
            label6.Text = "მისამართი";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 211);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 28;
            label5.Text = "საიტი";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 169);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 27;
            label4.Text = "ტელეფონი";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 120);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 26;
            label3.Text = "ელ-ფოსტა";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 76);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 25;
            label2.Text = "გვარი";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 24;
            label1.Text = "სახელი";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 255, 192);
            btnSave.Location = new Point(12, 298);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(288, 29);
            btnSave.TabIndex = 23;
            btnSave.Text = "დამატება";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(127, 257);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(176, 27);
            txtAddress.TabIndex = 21;
            // 
            // txtSite
            // 
            txtSite.Location = new Point(127, 207);
            txtSite.Name = "txtSite";
            txtSite.Size = new Size(176, 27);
            txtSite.TabIndex = 20;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(127, 162);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(176, 27);
            txtPhone.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(127, 117);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 27);
            txtEmail.TabIndex = 18;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(127, 69);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(176, 27);
            txtLastName.TabIndex = 17;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(127, 19);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(176, 27);
            txtFirstName.TabIndex = 16;
            // 
            // UserAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 341);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtAddress);
            Controls.Add(txtSite);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "UserAddForm";
            Text = "იუზერის დამატება";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private TextBox txtAddress;
        private TextBox txtSite;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
    }
}