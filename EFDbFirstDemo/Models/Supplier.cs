using System;
using System.Collections.Generic;

namespace EFDbFirstDemo.Models;

public partial class Supplier
{
    public int PersonId { get; set; }

    public string Gst { get; set; } = null!;

    public int Rating { get; set; }

    public string EmailId { get; set; } = null!;

    public string Mobile { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string AddressArea { get; set; } = null!;

    public string AddressCity { get; set; } = null!;

    public string AddressLocation { get; set; } = null!;

    public string AddressPincode { get; set; } = null!;

    public virtual ICollection<Product> ProductsProducts { get; set; } = new List<Product>();
}
