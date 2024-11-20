using System;
using System.Collections.Generic;

namespace EC_Shop3k1d.Data;

public partial class ShopVoucher
{
    public long Id { get; set; }

    public string Code { get; set; } = null!;

    public string? Description { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ShopCustomerVoucher> ShopCustomerVouchers { get; set; } = new List<ShopCustomerVoucher>();

    public virtual ICollection<ShopProductVoucher> ShopProductVouchers { get; set; } = new List<ShopProductVoucher>();
}
