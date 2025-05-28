using System;
using System.Collections.Generic;
using ICETASK.Models;
using Microsoft.EntityFrameworkCore;

namespace ICETASK.Data;

public partial class ICETASKDbContext : DbContext
{
    public ICETASKDbContext()
    {
    }

    public ICETASKDbContext(DbContextOptions<ICETASKDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Student__32C52A79962EF2E5");

            entity.ToTable("Student");

            entity.HasIndex(e => e.StudentNumber, "UQ__Student__DD81BF6CBD21EED9").IsUnique();

            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.FullName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Programme).IsUnicode(false);
            entity.Property(e => e.StudentNumber)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
