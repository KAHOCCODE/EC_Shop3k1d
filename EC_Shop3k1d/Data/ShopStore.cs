using System;
using System.Collections.Generic;

namespace EC_Shop3k1d.Data;

public partial class ShopStore
{
    public long Id { get; set; }

    public string StoreCode { get; set; } = null!;

    public string StoreName { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ShopExport> ShopExports { get; set; } = new List<ShopExport>();

    public virtual ICollection<ShopImport> ShopImports { get; set; } = new List<ShopImport>();
}
