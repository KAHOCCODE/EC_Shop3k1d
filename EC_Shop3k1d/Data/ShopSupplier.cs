using System;
using System.Collections.Generic;

namespace EC_Shop3k1d.Data;

public partial class ShopSupplier
{
    public long Id { get; set; }

    public string SupplierName { get; set; } = null!;

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ShopProduct> ShopProducts { get; set; } = new List<ShopProduct>();
}
