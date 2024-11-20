using System;
using System.Collections.Generic;

namespace EC_Shop3k1d.Data;

public partial class ShopCustomer
{
    public long Id { get; set; }

    public string CustomerName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ShopCustomerVoucher> ShopCustomerVouchers { get; set; } = new List<ShopCustomerVoucher>();

    public virtual ICollection<ShopOrder> ShopOrders { get; set; } = new List<ShopOrder>();

    public virtual ICollection<ShopProductReview> ShopProductReviews { get; set; } = new List<ShopProductReview>();
}
