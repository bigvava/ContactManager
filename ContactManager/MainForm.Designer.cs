namespace ContactManager
{
    partial class MainForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridUsers = new DataGridView();
            btnAddUser = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddUser);
            panel1.Location = new Point(3, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 404);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridUsers);
            panel2.Location = new Point(209, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 379);
            panel2.TabIndex = 1;
            // 
            // dataGridUsers
            // 
            dataGridUsers.AllowUserToAddRows = false;
            dataGridUsers.AllowUserToDeleteRows = false;
            dataGridUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsers.Location = new Point(17, 25);
            dataGridUsers.Name = "dataGridUsers";
            dataGridUsers.ReadOnly = true;
            dataGridUsers.RowHeadersWidth = 51;
            dataGridUsers.Size = new Size(537, 337);
            dataGridUsers.TabIndex = 0;
            dataGridUsers.CellContentClick += dataGridUsers_CellContentClick;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(10, 3);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(183, 52);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "მომხმარებლის დამატება";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridUsers;
        private Button btnAddUser;
    }
}