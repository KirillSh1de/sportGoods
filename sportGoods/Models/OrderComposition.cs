using System;
using System.Collections.Generic;

namespace sportGoods.Models;

public partial class OrderComposition
{
    public int Id { get; set; }

    public int FkIdProducts { get; set; }

    public int Count { get; set; }

    public int FkIdUsers { get; set; }

    public virtual Product FkIdProductsNavigation { get; set; } = null!;

    public virtual User FkIdUsersNavigation { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
