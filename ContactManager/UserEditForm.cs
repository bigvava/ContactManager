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
using Microsoft.EntityFrameworkCore;

namespace ContactManager
{
    public partial class UserEditForm : Form
    {
        private int _userId;
        private ContactsContext _db;
        private User _user;
        public UserEditForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _db = new ContactsContext();
            FillForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _user.FirstName = txtFirstName.Text;
            _user.LastName = txtLastName.Text;

            //(int)EnumContactTypes.Phone
            var phone = _user.Contacts.FirstOrDefault(x => x.ContactTypeId == (int)EnumContactTypes.Phone);
            phone.Text = txtPhone.Text;

            var email = _user.Contacts.FirstOrDefault(x => x.ContactTypeId == (int)EnumContactTypes.Email);
            email.Text = txtEmail.Text;

            var site = _user.Contacts.FirstOrDefault(x => x.ContactTypeId == (int)EnumContactTypes.Site);
            site.Text = txtSite.Text;

            var address = _user.Contacts.FirstOrDefault(x => x.ContactTypeId == (int)EnumContactTypes.Address);
            address.Text = txtAddress.Text;

            try
            {
                _db.SaveChanges();
                MessageBox.Show("Monacemebi warmatebit dakoreqtirda");
                this.Close();
            }
            catch (Exception ex)
            {

            }



        }

        private void FillForm()
        {
            _user = _db.Users.Include(x => x.Contacts).Where(x => x.Id == _userId).FirstOrDefault();
            if (_user != null)
            {
                txtFirstName.Text = _user.FirstName;
                txtLastName.Text = _user.LastName;
                lblId.Text += _user.Id.ToString();
                foreach (var contact in _user.Contacts)
                {
                    switch (contact.ContactTypeId)
                    {
                        case (int)EnumContactTypes.Phone:
                            txtPhone.Text = contact.Text;
                            break;
                        case (int)EnumContactTypes.Email:
                            txtEmail.Text = contact.Text;
                            break;
                        case (int)EnumContactTypes.Site:
                            txtSite.Text = contact.Text;
                            break;
                        case (int)EnumContactTypes.Address:
                            txtAddress.Text = contact.Text;
                            break;
                    }
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //foreach (var contact in _user.Contacts)
            //{
            //    _db.Remove(contact);
            //}
            _db.RemoveRange(_user.Contacts);
            _db.Remove(_user);

            try
            {
                _db.SaveChanges();
                MessageBox.Show("Warmatebit waishala");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
