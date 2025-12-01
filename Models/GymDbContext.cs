using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace gym.Models;

public partial class GymDbContext : DbContext
{
    public GymDbContext()
    {
    }

    public GymDbContext(DbContextOptions<GymDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Exercise> Exercises { get; set; }

    //Dont need for now, this tells EF how to connect if nothing is passed in aka a fallback
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserID).HasName("Users_pkey");

            entity.ToTable(tb => tb.HasComment("Table for users"));

            entity.Property(e => e.UserID)
                .HasColumnName("UserID");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Exercise>(entity =>
        {
            entity.ToTable("exercise");
            entity.HasKey(e => e.ExerciseID);

            entity.Property(e => e.ExerciseID)
             .HasColumnName("exerciseID");

            entity.Property(x => x.Name)
            .HasMaxLength(100)
            .HasColumnName("Name");

            entity.Property(x => x.Category)
            .HasMaxLength(100)
            .HasColumnName("Category");
        });
        

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
