using System;
using System.Collections.Generic;

namespace EC_Shop3k1d.Data;

public partial class ShopOrderDetail
{
    public long Id { get; set; }

    public long OrderId { get; set; }

    public long ProductId { get; set; }

    public decimal Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal? DiscountAmount { get; set; }

    public virtual ShopOrder Order { get; set; } = null!;

    public virtual ShopProduct Product { get; set; } = null!;
}
