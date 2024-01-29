﻿using System;
using System.Collections.Generic;

namespace ContactManager.DbModels;

public partial class ContactType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();
}
