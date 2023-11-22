using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MVCReactApp.Server.Models;

public partial class MvcreactContext : DbContext
{
    public MvcreactContext()
    {
    }

    public MvcreactContext(DbContextOptions<MvcreactContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Empleado> Empleados { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectModels;Database=MVCReact;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleados);

            entity.Property(e => e.IdEmpleados).HasColumnName("Id_Empleados");
            entity.Property(e => e.Correo).HasMaxLength(50);
            entity.Property(e => e.Domicilio).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
