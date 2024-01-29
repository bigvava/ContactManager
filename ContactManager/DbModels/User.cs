using System;
using System.Collections.Generic;

namespace ContactManager.DbModels;

public partial class User
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();
}
