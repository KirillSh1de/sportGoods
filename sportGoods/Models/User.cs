using System;
using System.Collections.Generic;

namespace sportGoods.Models;

public partial class User
{
    public int Id { get; set; }

    public int FkIdRole { get; set; }

    public string FullName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual Role FkIdRoleNavigation { get; set; } = null!;

    public virtual ICollection<OrderComposition> OrderCompositions { get; set; } = new List<OrderComposition>();
}
