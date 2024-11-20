using System;
using System.Collections.Generic;

namespace EC_Shop3k1d.Data;

public partial class AclUserHasRole
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public long RoleId { get; set; }

    public virtual AclRole Role { get; set; } = null!;

    public virtual AclUser User { get; set; } = null!;
}
