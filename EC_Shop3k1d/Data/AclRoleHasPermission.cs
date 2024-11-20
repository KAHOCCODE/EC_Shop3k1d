using System;
using System.Collections.Generic;

namespace EC_Shop3k1d.Data;

public partial class AclRoleHasPermission
{
    public long Id { get; set; }

    public long RoleId { get; set; }

    public long PermissionId { get; set; }

    public virtual AclPermission Permission { get; set; } = null!;

    public virtual AclRole Role { get; set; } = null!;
}
