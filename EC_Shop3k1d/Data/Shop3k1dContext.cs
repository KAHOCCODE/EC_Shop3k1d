using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EC_Shop3k1d.Data;

public partial class Shop3k1dContext : DbContext
{
    public Shop3k1dContext()
    {
    }

    public Shop3k1dContext(DbContextOptions<Shop3k1dContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AclPermission> AclPermissions { get; set; }

    public virtual DbSet<AclRole> AclRoles { get; set; }

    public virtual DbSet<AclRoleHasPermission> AclRoleHasPermissions { get; set; }

    public virtual DbSet<AclUser> AclUsers { get; set; }

    public virtual DbSet<AclUserHasPermission> AclUserHasPermissions { get; set; }

    public virtual DbSet<AclUserHasRole> AclUserHasRoles { get; set; }

    public virtual DbSet<ShopCategory> ShopCategories { get; set; }

    public virtual DbSet<ShopCustomer> ShopCustomers { get; set; }

    public virtual DbSet<ShopCustomerVoucher> ShopCustomerVouchers { get; set; }

    public virtual DbSet<ShopExport> ShopExports { get; set; }

    public virtual DbSet<ShopExportDetail> ShopExportDetails { get; set; }

    public virtual DbSet<ShopImport> ShopImports { get; set; }

    public virtual DbSet<ShopImportDetail> ShopImportDetails { get; set; }

    public virtual DbSet<ShopOrder> ShopOrders { get; set; }

    public virtual DbSet<ShopOrderDetail> ShopOrderDetails { get; set; }

    public virtual DbSet<ShopPaymentType> ShopPaymentTypes { get; set; }

    public virtual DbSet<ShopProduct> ShopProducts { get; set; }

    public virtual DbSet<ShopProductDiscount> ShopProductDiscounts { get; set; }

    public virtual DbSet<ShopProductImage> ShopProductImages { get; set; }

    public virtual DbSet<ShopProductReview> ShopProductReviews { get; set; }

    public virtual DbSet<ShopProductVoucher> ShopProductVouchers { get; set; }

    public virtual DbSet<ShopStore> ShopStores { get; set; }

    public virtual DbSet<ShopSupplier> ShopSuppliers { get; set; }

    public virtual DbSet<ShopVoucher> ShopVouchers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-3TRF427\\HOANGKA;Initial Catalog=Shop3k1d;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AclPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__acl_perm__3213E83FCE783C10");

            entity.ToTable("acl_permissions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.GuardName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("guard_name");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<AclRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__acl_role__3213E83F537E205F");

            entity.ToTable("acl_roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.GuardName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("guard_name");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<AclRoleHasPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__acl_role__3213E83F6B5551E7");

            entity.ToTable("acl_role_has_permissions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");
            entity.Property(e => e.RoleId).HasColumnName("role_id");

            entity.HasOne(d => d.Permission).WithMany(p => p.AclRoleHasPermissions)
                .HasForeignKey(d => d.PermissionId)
                .HasConstraintName("FK__acl_role___permi__0C85DE4D");

            entity.HasOne(d => d.Role).WithMany(p => p.AclRoleHasPermissions)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__acl_role___role___0D7A0286");
        });

        modelBuilder.Entity<AclUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__acl_user__3213E83F53A85110");

            entity.ToTable("acl_users");

            entity.HasIndex(e => e.Email, "UQ__acl_user__AB6E61644CA348AB").IsUnique();

            entity.HasIndex(e => e.Username, "UQ__acl_user__F3DBC5721A5CE266").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Avatar)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("avatar");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Password)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.Username)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<AclUserHasPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__acl_user__3213E83FD7B6BD93");

            entity.ToTable("acl_user_has_permissions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Permission).WithMany(p => p.AclUserHasPermissions)
                .HasForeignKey(d => d.PermissionId)
                .HasConstraintName("FK__acl_user___permi__0E6E26BF");

            entity.HasOne(d => d.User).WithMany(p => p.AclUserHasPermissions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__acl_user___user___0F624AF8");
        });

        modelBuilder.Entity<AclUserHasRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__acl_user__3213E83F9DF83321");

            entity.ToTable("acl_user_has_roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Role).WithMany(p => p.AclUserHasRoles)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__acl_user___role___10566F31");

            entity.HasOne(d => d.User).WithMany(p => p.AclUserHasRoles)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__acl_user___user___114A936A");
        });

        modelBuilder.Entity<ShopCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__shop_cat__3213E83F00C6491F");

            entity.ToTable("shop_categories");

            entity.HasIndex(e => e.CategoryName, "UQ__shop_cat__5189E255ADE317FB").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("category_name");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ShopCustomer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__shop_cus__3213E83FDC2965D6");

            entity.ToTable("shop_customers");

            entity.HasIndex(e => e.Email, "UQ__shop_cus__AB6E6164C6554438").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("customer_name");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ShopCustomerVoucher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__shop_cus__3213E83F1F528D76");

            entity.ToTable("shop_customer_vouchers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.VoucherId).HasColumnName("voucher_id");

            entity.HasOne(d => d.Customer).WithMany(p => p.ShopCustomerVouchers)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__shop_cust__custo__123EB7A3");

            entity.HasOne(d => d.Voucher).WithMany(p => p.ShopCustomerVouchers)
                .HasForeignKey(d => d.VoucherId)
                .HasConstraintName("FK__shop_cust__vouch__1332DBDC");
        });

        modelBuilder.Entity<ShopExport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__shop_exp__3213E83FC43799C9");

            entity.ToTable("shop_exports");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.StoreId).HasColumnName("store_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Store).WithMany(p => p.ShopExports)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK__shop_expo__store__160F4887");

            entity.HasOne(d => d.User).WithMany(p => p.ShopExports)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__shop_expo__user___17036CC0");
        });

        modelBuilder.Entity<ShopExportDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__shop_exp__3213E83FB55D0FB5");

            entity.ToTable("shop_export_details");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ExportId).HasColumnName("export_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Quantity)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("quantity");

            entity.HasOne(d => d.Export).WithMany(p => p.ShopExportDetails)
                .HasForeignKey(d => d.ExportId)
                .HasConstraintName("FK__shop_expo__expor__14270015");

            entity.HasOne(d => d.Product).WithMany(p => p.ShopExportDetails)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__shop_expo__produ__151B244E");
        });

        modelBuilder.Entity<ShopImport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__shop_imp__3213E83F16D73FB0");

            entity.ToTable("shop_imports");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.StoreId).HasColumnName("store_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Store).WithMany(p => p.ShopImports)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK__shop_impo__store__19DFD96B");

            entity.HasOne(d => d.User).WithMany(p => p.ShopImports)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__shop_impo__user___1AD3FDA4");
        });

        modelBuilder.Entity<ShopImportDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__shop_imp__3213E83FD1D8B693");

            entity.ToTable("shop_import_details");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ImportId).HasColumnName("import_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Quantity)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("quantity");

            entity.HasOne(d => d.Import).WithMany(p => p.ShopImportDetails)
                .HasForeignKey(d => d.ImportId)
                .HasConstraintName("FK__shop_impo__impor__17F790F9");

            entity.HasOne(d => d.Product).WithMany(p => p.ShopImportDetails)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__shop_impo__produ__18EBB532");
        });

        modelBuilder.Entity<ShopOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__shop_ord__3213E83F0A822B2A");

            entity.ToTable("shop_orders");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.OrderDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("order_date");
            entity.Property(e => e.PaymentTypeId).HasColumnName("payment_type_id");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total_amount");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Customer).WithMany(p => p.ShopOrders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__shop_orde__custo__1DB06A4F");

            entity.HasOne(d => d.PaymentType).WithMany(p => p.ShopOrders)
                .HasForeignKey(d => d.PaymentTypeId)
                .HasConstraintName("FK__shop_orde__payme__1EA48E88");

            entity.HasOne(d => d.User).WithMany(p => p.ShopOrders)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__shop_orde__user___1F98B2C1");
        });

        modelBuilder.Entity<ShopOrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__shop_ord__3213E83F1357FAFD");

            entity.ToTable("shop_order_details");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DiscountAmount)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("discount_amount");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Quantity)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("quantity");
            entity.Property(e => e.UnitPrice)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("unit_price");

            entity.HasOne(d => d.Order).WithMany(p => p.ShopOrderDetails)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__shop_orde__order__1BC821DD");

            entity.HasOne(d => d.Product).WithMany(p => p.ShopOrderDetails)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__shop_orde__produ__1CBC4616");
        });

        modelBuilder.Entity<ShopPaymentType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__shop_pay__3213E83FADD3E462");

            entity.ToTable("shop_payment_types");

            entity.HasIndex(e => e.Name, "UQ__shop_pay__72E12F1B01134F40").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ShopProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__shop_pro__3213E83FA5768C14");

            entity.ToTable("shop_products");

            entity.HasIndex(e => e.ProductCode, "UQ__shop_pro__AE1A8CC41F49A713").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("price");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("product_code");
            entity.Property(e => e.ProductName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("product_name");
            entity.Property(e => e.SupplierId).HasColumnName("supplier_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Category).WithMany(p => p.ShopProducts)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__shop_prod__categ__2645B050");

            entity.HasOne(d => d.Supplier).WithMany(p => p.ShopProducts)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK__shop_prod__suppl__2739D489");
        });

        modelBuilder.Entity<ShopProductDiscount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__shop_pro__3213E83FB67D8ECC");

            entity.ToTable("shop_product_discounts");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DiscountAmount).HasColumnName("discount_amount");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");

            entity.HasOne(d => d.Product).WithMany(p => p.ShopProductDiscounts)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__shop_prod__produ__208CD6FA");
        });

        modelBuilder.Entity<ShopProductImage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__shop_pro__3213E83F38F28A27");

            entity.ToTable("shop_product_images");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("image_url");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Product).WithMany(p => p.ShopProductImages)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__shop_prod__produ__2180FB33");
        });

        modelBuilder.Entity<ShopProductReview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__shop_pro__3213E83F29F81633");

            entity.ToTable("shop_product_reviews");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Customer).WithMany(p => p.ShopProductReviews)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__shop_prod__custo__22751F6C");

            entity.HasOne(d => d.Product).WithMany(p => p.ShopProductReviews)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__shop_prod__produ__236943A5");
        });

        modelBuilder.Entity<ShopProductVoucher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__shop_pro__3213E83FE3C81304");

            entity.ToTable("shop_product_vouchers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.VoucherId).HasColumnName("voucher_id");

            entity.HasOne(d => d.Product).WithMany(p => p.ShopProductVouchers)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__shop_prod__produ__245D67DE");

            entity.HasOne(d => d.Voucher).WithMany(p => p.ShopProductVouchers)
                .HasForeignKey(d => d.VoucherId)
                .HasConstraintName("FK__shop_prod__vouch__25518C17");
        });

        modelBuilder.Entity<ShopStore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__shop_sto__3213E83FAB97BE81");

            entity.ToTable("shop_stores");

            entity.HasIndex(e => e.StoreCode, "UQ__shop_sto__908E6898B149825B").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.StoreCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("store_code");
            entity.Property(e => e.StoreName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("store_name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ShopSupplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__shop_sup__3213E83F0417E340");

            entity.ToTable("shop_suppliers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("supplier_name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ShopVoucher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__shop_vou__3213E83F667A65EC");

            entity.ToTable("shop_vouchers");

            entity.HasIndex(e => e.Code, "UQ__shop_vou__357D4CF92E8097BB").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
