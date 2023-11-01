using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirstApproach.Data;

public partial class MyDatabaseContext : DbContext
{
    public MyDatabaseContext()
    {
    }

    public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("User Id=sa;password=examlyMssql@123;server=localhost;database=MyDatabase;trusted_connection=false;Persist Security Info=False;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__departme__B2079BED710288BB");

            entity.ToTable("departments");

            entity.Property(e => e.DepartmentName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__employee__7AD04F11DECC9B00");

            entity.ToTable("employees");

            entity.Property(e => e.EmployeeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JoinDate).HasColumnType("datetime");
            entity.Property(e => e.Salary).HasColumnType("money");

            entity.HasOne(d => d.Department).WithMany(p => p.Employees)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK__employees__Depar__38996AB5");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
