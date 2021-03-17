using EFCoreTutorial.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreTutorial.Data.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // make the configurations
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=efcore;Persist Security Info=True;User ID=sa;Password=Salih123!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");

            modelBuilder.Entity<Student>(entity => 
            {
                entity.ToTable("students");

                entity.Property(i => i.Id).HasColumnName("id").HasColumnType("int").UseIdentityColumn().IsRequired();
                entity.Property(i => i.FirstName).HasColumnName("first_name").HasColumnType("nvarchar").HasMaxLength(250);
                entity.Property(i => i.LastName).HasColumnName("last_name").HasColumnType("nvarchar").HasMaxLength(250);
                entity.Property(i => i.Number).HasColumnName("number");
                entity.Property(i => i.BirthDate).HasColumnName("birth_date");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("teachers");

                entity.Property(i => i.Id).HasColumnName("id").UseIdentityColumn();
                entity.Property(i => i.FirstName).HasColumnName("first_name").HasColumnType("nvarchar").HasMaxLength(100);
                entity.Property(i => i.LastName).HasColumnName("last_name").HasColumnType("nvarchar").HasMaxLength(100);
                entity.Property(i => i.BirthDate).HasColumnName("birth_date");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("courses");

                entity.Property(i => i.Id).HasColumnName("id").UseIdentityColumn();
                entity.Property(i => i.Name).HasColumnName("name").HasColumnType("nvarchar").HasMaxLength(100);
                entity.Property(i => i.IsActive).HasColumnName("is_active");
            });



            base.OnModelCreating(modelBuilder);
        }


    }
}
