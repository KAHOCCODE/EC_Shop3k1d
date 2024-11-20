using System;
using System.Collections.Generic;

namespace EC_Shop3k1d.Data;

public partial class ShopProductImage
{
    public long Id { get; set; }

    public long ProductId { get; set; }

    public string ImageUrl { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ShopProduct Product { get; set; } = null!;
}
