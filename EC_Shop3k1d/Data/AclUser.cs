using System;
using System.Collections.Generic;

namespace EC_Shop3k1d.Data;

public partial class AclUser
{
    public long Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateOnly? Birthday { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public long? CountryId { get; set; }

    public string? Avatar { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<AclUserHasPermission> AclUserHasPermissions { get; set; } = new List<AclUserHasPermission>();

    public virtual ICollection<AclUserHasRole> AclUserHasRoles { get; set; } = new List<AclUserHasRole>();

    public virtual ICollection<ShopExport> ShopExports { get; set; } = new List<ShopExport>();

    public virtual ICollection<ShopImport> ShopImports { get; set; } = new List<ShopImport>();

    public virtual ICollection<ShopOrder> ShopOrders { get; set; } = new List<ShopOrder>();
}
