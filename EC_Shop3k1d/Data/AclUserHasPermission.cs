using System;
using System.Collections.Generic;

namespace EC_Shop3k1d.Data;

public partial class AclUserHasPermission
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public long PermissionId { get; set; }

    public virtual AclPermission Permission { get; set; } = null!;

    public virtual AclUser User { get; set; } = null!;
}
