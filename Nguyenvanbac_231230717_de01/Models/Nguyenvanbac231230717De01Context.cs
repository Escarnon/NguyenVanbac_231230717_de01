using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Nguyenvanbac_231230717_de01.Models;

public partial class Nguyenvanbac231230717De01Context : DbContext
{
    public Nguyenvanbac231230717De01Context()
    {
    }

    public Nguyenvanbac231230717De01Context(DbContextOptions<Nguyenvanbac231230717De01Context> options)
        : base(options)
    {
    }

    public virtual DbSet<NvbComputer> NvbComputers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=HAHAHA\\SQLEXPRESS;Database=nguyenvanbac_231230717_de01;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NvbComputer>(entity =>
        {
            entity.HasKey(e => e.NvbComId).HasName("PK__NvbCompu__3C0749DC585B41A2");

            entity.ToTable("NvbComputer");

            entity.Property(e => e.NvbComId)
                .ValueGeneratedNever()
                .HasColumnName("nvbComId");
            entity.Property(e => e.NvbComImage)
                .HasMaxLength(255)
                .HasColumnName("nvbComImage");
            entity.Property(e => e.NvbComName)
                .HasMaxLength(100)
                .HasColumnName("nvbComName");
            entity.Property(e => e.NvbComPrice)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("nvbComPrice");
            entity.Property(e => e.NvbComStatus).HasColumnName("nvbComStatus");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
