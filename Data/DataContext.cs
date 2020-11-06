using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FluentAPI.Data
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Post> Post { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);
                  

                entity.Property(e => e.Slug)
                    .HasColumnName("SLUG")
                    .HasMaxLength(255);
                   
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.Property(e => e.PostId).HasColumnName("POST_ID");

                entity.Property(e => e.CategoryId).HasColumnName("CATEGORY_ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION");
                    .

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(2000);
                    

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Post__CATEGORY_I__1273C1CD");
            });
        }
    }
}