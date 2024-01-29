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
using ContactManager.DTOs;
using Microsoft.EntityFrameworkCore;

namespace ContactManager
{
    enum EnumContactTypes
    {
        Phone = 1,
        Email = 2,
        Site = 3,
        Address = 4
    }
    public partial class MainForm : Form
    {
        private ContactsContext _db;
        private List<UserDto> _ums;
        public MainForm()
        {
            InitializeComponent();
            _db = new ContactsContext();
            PopulateGridData();
        }

        public void PopulateGridData()
        {
            var users = _db.Users.Include(x => x.Contacts).ToList();
            //List<UserModel> ums = new List<UserModel>();
            _ums = new List<UserDto>();
            foreach (User user in users)
            {
                UserDto um = new UserDto();
                um.UserId = user.Id;
                um.FirstName = user.FirstName;
                um.LastName = user.LastName;

                foreach (var contact in user.Contacts)
                {
                    switch (contact.ContactTypeId)
                    {
                        case (int)EnumContactTypes.Phone:
                            um.Phone = contact.Text;
                            break;
                        case (int)EnumContactTypes.Email:
                            um.Email = contact.Text;
                            break;
                        case (int)EnumContactTypes.Site:
                            um.Site = contact.Text;
                            break;
                        case (int)EnumContactTypes.Address:
                            um.Address = contact.Text;
                            break;
                    }
                }
                _ums.Add(um);
            }


            dataGridUsers.DataSource = _ums;
            dataGridUsers.Columns["FirstName"].HeaderText = "სახელი";
            dataGridUsers.Columns["LastName"].HeaderText = "გვარი";
            dataGridUsers.Columns["Phone"].HeaderText = "ტელეფონის ნომერი";
            dataGridUsers.Columns["Email"].HeaderText = "ელფოსტა";
            dataGridUsers.Columns["Site"].HeaderText = "ვებ-საიტი";
            dataGridUsers.Columns["Address"].HeaderText = "მისამართი";
        }

        private void dataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var user = _ums[index];
            var name = user.FirstName;

            UserEditForm uef = new UserEditForm(user.UserId);
            uef.Show();

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserAddForm newForm = new UserAddForm();
            newForm.Show();
        }
    }
}
