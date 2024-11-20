using System;
using System.Collections.Generic;

namespace EC_Shop3k1d.Data;

public partial class ShopProduct
{
    public long Id { get; set; }

    public string ProductCode { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public long CategoryId { get; set; }

    public long SupplierId { get; set; }

    public decimal Price { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ShopCategory Category { get; set; } = null!;

    public virtual ICollection<ShopExportDetail> ShopExportDetails { get; set; } = new List<ShopExportDetail>();

    public virtual ICollection<ShopImportDetail> ShopImportDetails { get; set; } = new List<ShopImportDetail>();

    public virtual ICollection<ShopOrderDetail> ShopOrderDetails { get; set; } = new List<ShopOrderDetail>();

    public virtual ICollection<ShopProductDiscount> ShopProductDiscounts { get; set; } = new List<ShopProductDiscount>();

    public virtual ICollection<ShopProductImage> ShopProductImages { get; set; } = new List<ShopProductImage>();

    public virtual ICollection<ShopProductReview> ShopProductReviews { get; set; } = new List<ShopProductReview>();

    public virtual ICollection<ShopProductVoucher> ShopProductVouchers { get; set; } = new List<ShopProductVoucher>();

    public virtual ShopSupplier Supplier { get; set; } = null!;
}
