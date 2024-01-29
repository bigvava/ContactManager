namespace ContactManager
{
    partial class UserEditForm
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtSite = new TextBox();
            txtAddress = new TextBox();
            lblId = new Label();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(125, 47);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(176, 27);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(125, 97);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(176, 27);
            txtLastName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(125, 145);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(125, 190);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(176, 27);
            txtPhone.TabIndex = 3;
            // 
            // txtSite
            // 
            txtSite.Location = new Point(125, 235);
            txtSite.Name = "txtSite";
            txtSite.Size = new Size(176, 27);
            txtSite.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(125, 285);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(176, 27);
            txtAddress.TabIndex = 5;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 14);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 20);
            lblId.TabIndex = 6;
            lblId.Text = "Id:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 255, 192);
            btnSave.Location = new Point(10, 326);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "შენახვა";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 54);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 9;
            label1.Text = "სახელი";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 10;
            label2.Text = "გვარი";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 148);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 11;
            label3.Text = "ელ-ფოსტა";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 197);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 12;
            label4.Text = "ტელეფონი";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 239);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 13;
            label5.Text = "საიტი";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 288);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 14;
            label6.Text = "მისამართი";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(171, 326);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "წაშლა";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // UserEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 367);
            Controls.Add(btnDelete);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(lblId);
            Controls.Add(txtAddress);
            Controls.Add(txtSite);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "UserEditForm";
            Text = "UserEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtSite;
        private TextBox txtAddress;
        private Label lblId;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnDelete;
    }
}