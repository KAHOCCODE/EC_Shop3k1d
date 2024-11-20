using System;
using System.Collections.Generic;

namespace EC_Shop3k1d.Data;

public partial class ShopProductVoucher
{
    public long Id { get; set; }

    public long ProductId { get; set; }

    public long VoucherId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ShopProduct Product { get; set; } = null!;

    public virtual ShopVoucher Voucher { get; set; } = null!;
}
