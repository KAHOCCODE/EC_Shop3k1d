using System;
using System.Collections.Generic;

namespace EC_Shop3k1d.Data;

public partial class ShopProductReview
{
    public long Id { get; set; }

    public long ProductId { get; set; }

    public long CustomerId { get; set; }

    public int Rating { get; set; }

    public string? Comment { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ShopCustomer Customer { get; set; } = null!;

    public virtual ShopProduct Product { get; set; } = null!;
}
