using System;
using System.Collections.Generic;

namespace EC_Shop3k1d.Data;

public partial class ShopOrder
{
    public long Id { get; set; }

    public long CustomerId { get; set; }

    public long UserId { get; set; }

    public long PaymentTypeId { get; set; }

    public DateTime? OrderDate { get; set; }

    public decimal TotalAmount { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ShopCustomer Customer { get; set; } = null!;

    public virtual ShopPaymentType PaymentType { get; set; } = null!;

    public virtual ICollection<ShopOrderDetail> ShopOrderDetails { get; set; } = new List<ShopOrderDetail>();

    public virtual AclUser User { get; set; } = null!;
}
