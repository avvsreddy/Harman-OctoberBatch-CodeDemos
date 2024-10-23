using System;
using System.Collections.Generic;

namespace EFDbFirstDemo.Models;

public partial class Customer
{
    public int PersonId { get; set; }

    public int Discount { get; set; }

    public string EmailId { get; set; } = null!;

    public string Mobile { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string AddressArea { get; set; } = null!;

    public string AddressCity { get; set; } = null!;

    public string AddressLocation { get; set; } = null!;

    public string AddressPincode { get; set; } = null!;
}
