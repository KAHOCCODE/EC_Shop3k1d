using System;
using System.Collections.Generic;

namespace EC_Shop3k1d.Data;

public partial class ShopExport
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public long UserId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ShopExportDetail> ShopExportDetails { get; set; } = new List<ShopExportDetail>();

    public virtual ShopStore Store { get; set; } = null!;

    public virtual AclUser User { get; set; } = null!;
}
