using System;
using System.Collections.Generic;

namespace EC_Shop3k1d.Data;

public partial class AclPermission
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string GuardName { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<AclRoleHasPermission> AclRoleHasPermissions { get; set; } = new List<AclRoleHasPermission>();

    public virtual ICollection<AclUserHasPermission> AclUserHasPermissions { get; set; } = new List<AclUserHasPermission>();
}
