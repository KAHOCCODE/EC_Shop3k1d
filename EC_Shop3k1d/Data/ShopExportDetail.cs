using System;
using System.Collections.Generic;

namespace EC_Shop3k1d.Data;

public partial class ShopExportDetail
{
    public long Id { get; set; }

    public long ExportId { get; set; }

    public long ProductId { get; set; }

    public decimal Quantity { get; set; }

    public virtual ShopExport Export { get; set; } = null!;

    public virtual ShopProduct Product { get; set; } = null!;
}
