using System;
using System.Collections.Generic;

namespace EC_Shop3k1d.Data;

public partial class ShopProductDiscount
{
    public long Id { get; set; }

    public long ProductId { get; set; }

    public double DiscountAmount { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public virtual ShopProduct Product { get; set; } = null!;
}
