using System;
using System.Collections.Generic;

namespace sportGoods.Models;

public partial class Order
{
    public int Id { get; set; }

    public int NumberOrder { get; set; }

    public int FkIdOrderCompositions { get; set; }

    public DateOnly Date { get; set; }

    public DateOnly DateDelivery { get; set; }

    public int FkIdPickUpPoints { get; set; }

    public string FullName { get; set; } = null!;

    public int CodeOrder { get; set; }

    public int FkIdStatuses { get; set; }

    public virtual OrderComposition FkIdOrderCompositionsNavigation { get; set; } = null!;

    public virtual PickUpPoint FkIdPickUpPointsNavigation { get; set; } = null!;

    public virtual Status FkIdStatusesNavigation { get; set; } = null!;
}
