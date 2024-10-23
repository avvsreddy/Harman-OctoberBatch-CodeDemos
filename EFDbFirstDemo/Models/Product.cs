using System;
using System.Collections.Generic;

namespace EFDbFirstDemo.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public int Rate { get; set; }

    public string Brand { get; set; } = null!;

    public bool InStock { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Supplier> SuppliersPeople { get; set; } = new List<Supplier>();
}
