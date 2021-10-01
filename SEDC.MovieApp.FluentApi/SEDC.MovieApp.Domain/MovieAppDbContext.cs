using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.Domain
{
    public class MovieAppDbContext:DbContext
    {
        public MovieAppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>()
               .Property(x => x.Id)
               .HasMaxLength(30)
               .IsRequired();

            modelBuilder.Entity<Movie>()
                .Property(x => x.Title)
                .HasMaxLength(30);
                
            modelBuilder.Entity<Movie>()
                .Property(x => x.Description)
                .HasMaxLength(30);
            modelBuilder.Entity<Movie>()
                .Property(x => x.Year)
                .HasMaxLength(30);


            modelBuilder.Entity<Movie>()
               .Property(x => x.Genre)
               .HasMaxLength(30);
               
        }
    }
}
