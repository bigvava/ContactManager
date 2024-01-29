using System;
using System.Collections.Generic;

namespace ContactManager.DbModels;

public partial class Contact
{
    public int Id { get; set; }

    public string Text { get; set; } = null!;

    public int UserId { get; set; }

    public int ContactTypeId { get; set; }

    public virtual ContactType ContactType { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
