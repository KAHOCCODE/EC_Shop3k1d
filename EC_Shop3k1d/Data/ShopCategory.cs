using System;
using System.Collections.Generic;

namespace EC_Shop3k1d.Data;

public partial class ShopCategory
{
    public long Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ShopProduct> ShopProducts { get; set; } = new List<ShopProduct>();
}
