using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ThemeInt.DataBase;

public partial class JobPortalEfContext : DbContext
{
    public JobPortalEfContext()
    {
    }

    public JobPortalEfContext(DbContextOptions<JobPortalEfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<JobMaster> JobMasters { get; set; }

    public virtual DbSet<JobType> JobTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=VISAL\\MSSQLSERVER02;Database=JobPortalEF;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<JobMaster>(entity =>
        {
            entity.HasKey(e => e.JobId);

            entity.ToTable("JobMaster");

            entity.Property(e => e.JobId).HasColumnName("JobID");
            entity.Property(e => e.JobDiscription)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JobTitle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JobTypeId).HasColumnName("JobTypeID");

            entity.HasOne(d => d.JobType).WithMany(p => p.JobMasters)
                .HasForeignKey(d => d.JobTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobMaster_JobType");
        });

        modelBuilder.Entity<JobType>(entity =>
        {
            entity.ToTable("JobType");

            entity.Property(e => e.JobTypeName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
