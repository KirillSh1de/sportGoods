using System;
using System.Collections.Generic;

namespace sportGoods.Models;

public partial class PickUpPoint
{
    public int Id { get; set; }

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public int HouseNumber { get; set; }

    public string NumberPhone { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
