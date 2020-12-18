using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Models
{
    public class APIDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<ActorMovie> ActorMovie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorMovie>()
                .HasKey(bc => new { bc.ActorId, bc.MovieId });
            modelBuilder.Entity<ActorMovie>()
                .HasOne(bc => bc.Actor)
                .WithMany(b => b.Movies)
                .HasForeignKey(bc => bc.ActorId);
            modelBuilder.Entity<ActorMovie>()
                .HasOne(bc => bc.Movie)
                .WithMany(c => c.Actors)
                .HasForeignKey(bc => bc.MovieId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=MOVIEDB;Integrated Security=True");
        }


    }
}
