using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using sportGoods.Models;

namespace sportGoods;

public partial class Pr3Context : DbContext
{
    public Pr3Context()
    {
    }

    public Pr3Context(DbContextOptions<Pr3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Manufacture> Manufactures { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderComposition> OrderCompositions { get; set; }

    public virtual DbSet<PickUpPoint> PickUpPoints { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductName> ProductNames { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=pr3;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("categories_pkey");

            entity.ToTable("categories");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Manufacture>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("manufactures_pkey");

            entity.ToTable("manufactures");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("orders_pkey");

            entity.ToTable("orders");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeOrder).HasColumnName("code_order");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.DateDelivery).HasColumnName("date_delivery");
            entity.Property(e => e.FkIdOrderCompositions).HasColumnName("fk_id_order_compositions");
            entity.Property(e => e.FkIdPickUpPoints).HasColumnName("fk_id_pick_up_points");
            entity.Property(e => e.FkIdStatuses).HasColumnName("fk_id_statuses");
            entity.Property(e => e.FullName).HasColumnName("full_name");
            entity.Property(e => e.NumberOrder).HasColumnName("number_order");

            entity.HasOne(d => d.FkIdOrderCompositionsNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.FkIdOrderCompositions)
                .HasConstraintName("orders_fk_id_order_compositions_fkey");

            entity.HasOne(d => d.FkIdPickUpPointsNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.FkIdPickUpPoints)
                .HasConstraintName("orders_fk_id_pick_up_points_fkey");

            entity.HasOne(d => d.FkIdStatusesNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.FkIdStatuses)
                .HasConstraintName("orders_fk_id_statuses_fkey");
        });

        modelBuilder.Entity<OrderComposition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_compositions_pkey");

            entity.ToTable("order_compositions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.FkIdProducts).HasColumnName("fk_id_products");
            entity.Property(e => e.FkIdUsers).HasColumnName("fk_id_users");

            entity.HasOne(d => d.FkIdProductsNavigation).WithMany(p => p.OrderCompositions)
                .HasForeignKey(d => d.FkIdProducts)
                .HasConstraintName("order_compositions_fk_id_products_fkey");

            entity.HasOne(d => d.FkIdUsersNavigation).WithMany(p => p.OrderCompositions)
                .HasForeignKey(d => d.FkIdUsers)
                .HasConstraintName("order_compositions_fk_id_users_fkey");
        });

        modelBuilder.Entity<PickUpPoint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pick_up_points_pkey");

            entity.ToTable("pick_up_points");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.HouseNumber).HasColumnName("house_number");
            entity.Property(e => e.NumberPhone).HasColumnName("number_phone");
            entity.Property(e => e.Street).HasColumnName("street");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("products_pkey");

            entity.ToTable("products");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Article).HasColumnName("article");
            entity.Property(e => e.CountOnWarehouse).HasColumnName("count_on_warehouse");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Discount).HasColumnName("discount");
            entity.Property(e => e.FkIdCategories).HasColumnName("fk_id_categories");
            entity.Property(e => e.FkIdManufacturers).HasColumnName("fk_id_manufacturers");
            entity.Property(e => e.FkIdProductNames).HasColumnName("fk_id_product_names");
            entity.Property(e => e.FkIdSuppliers).HasColumnName("fk_id_suppliers");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.UnitOfMeasurement).HasColumnName("unit_of_measurement");

            entity.HasOne(d => d.FkIdCategoriesNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.FkIdCategories)
                .HasConstraintName("products_fk_id_categories_fkey");

            entity.HasOne(d => d.FkIdManufacturersNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.FkIdManufacturers)
                .HasConstraintName("products_fk_id_manufacturers_fkey");

            entity.HasOne(d => d.FkIdProductNamesNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.FkIdProductNames)
                .HasConstraintName("products_fk_id_product_names_fkey");

            entity.HasOne(d => d.FkIdSuppliersNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.FkIdSuppliers)
                .HasConstraintName("products_fk_id_suppliers_fkey");
        });

        modelBuilder.Entity<ProductName>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_names_pkey");

            entity.ToTable("product_names");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameRole).HasColumnName("name_role");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("statuses_pkey");

            entity.ToTable("statuses");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("suppliers_pkey");

            entity.ToTable("suppliers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FkIdRole).HasColumnName("fk_id_role");
            entity.Property(e => e.FullName).HasColumnName("full_name");
            entity.Property(e => e.Password).HasColumnName("password");

            entity.HasOne(d => d.FkIdRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.FkIdRole)
                .HasConstraintName("users_fk_id_role_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
