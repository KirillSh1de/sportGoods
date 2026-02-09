using System;
using System.Collections.Generic;

namespace sportGoods.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Article { get; set; } = null!;

    public int FkIdProductNames { get; set; }

    public int FkIdCategories { get; set; }

    public int FkIdManufacturers { get; set; }

    public int FkIdSuppliers { get; set; }

    public int Price { get; set; }

    public string UnitOfMeasurement { get; set; } = null!;

    public int? Discount { get; set; }

    public int CountOnWarehouse { get; set; }

    public string Description { get; set; } = null!;

    public virtual Category FkIdCategoriesNavigation { get; set; } = null!;

    public virtual Manufacture FkIdManufacturersNavigation { get; set; } = null!;

    public virtual ProductName FkIdProductNamesNavigation { get; set; } = null!;

    public virtual Supplier FkIdSuppliersNavigation { get; set; } = null!;

    public virtual ICollection<OrderComposition> OrderCompositions { get; set; } = new List<OrderComposition>();
}
