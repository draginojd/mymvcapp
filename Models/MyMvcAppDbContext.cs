using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace mymvcapp.Models;

public partial class MyMvcAppDbContext : DbContext
{
    public MyMvcAppDbContext()
    {
    }

    public MyMvcAppDbContext(DbContextOptions<MyMvcAppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<UserRegistration> UserRegistrations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-8E0C2UV\\SQLEXPRESS;Database=MyMvcAppDB;Integrated Security=true;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK_Customer");

            entity.Property(e => e.CustomerId)
                .ValueGeneratedNever()
                .HasColumnName("CustomerID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Email).IsUnicode(false);
            entity.Property(e => e.FirstName).IsUnicode(false);
            entity.Property(e => e.LastName).IsUnicode(false);
            entity.Property(e => e.Username).IsUnicode(false);
        });

        modelBuilder.Entity<UserRegistration>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UserRegi__1788CC4C04A79FF7");

            entity.ToTable("UserRegistration");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
