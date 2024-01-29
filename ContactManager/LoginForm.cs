using ContactManager.DbModels;

namespace ContactManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            ContactsContext _db = new ContactsContext();
            var user = _db.Users.Where(x => x.UserName == userName).FirstOrDefault();

            if (user == null)
            {
                MessageBox.Show("Login Failed");
            }
            else
            {
                using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
                {
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);
                    var generatedCode = Convert.ToHexString(hashBytes);

                    if (generatedCode == user.PasswordHash)
                    {
                        MainForm mainForm = new MainForm();
                        mainForm.Closed += (s, args) => this.Close();
                        this.Hide();
                        mainForm.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Login Failed");
                    }
                }
            }

            



        }
    }
}
