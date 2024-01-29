using ContactManager.DbModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class UserAddForm : Form
    {
        private ContactsContext _db;
        public UserAddForm()
        {
            InitializeComponent();
            _db = new ContactsContext();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            List<Contact> contacts = new List<Contact>();
            contacts.Add(new Contact
            {
                ContactTypeId = (int)EnumContactTypes.Phone,
                Text = txtPhone.Text
            });

            contacts.Add(new Contact
            {
                ContactTypeId = (int)EnumContactTypes.Email,
                Text = txtEmail.Text
            });

            contacts.Add(new Contact
            {
                ContactTypeId = (int)EnumContactTypes.Site,
                Text = txtSite.Text
            });

            contacts.Add(new Contact
            {
                ContactTypeId = (int)EnumContactTypes.Address,
                Text = txtAddress.Text
            });


            User u = new User()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Contacts = contacts
            };

            try
            {
                _db.Add(u);
                _db.SaveChanges();
                var id = u.Id;
                var text = $"მომხმარებელი ID-ით:{id} წარმატებით დაემატა";
                MessageBox.Show(text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
            
        }
    }
}
