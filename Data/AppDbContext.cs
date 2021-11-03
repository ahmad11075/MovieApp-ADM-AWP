using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieApp.Models;

namespace MovieApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });
            modelBuilder.Entity<Customer_Criteria>().HasKey(cc => new
            {
                cc.CustomerId,
                cc.CriteriaId
            });
            modelBuilder.Entity<Customer_Hobby>().HasKey(ch => new
            {
                ch.CustomerId,
                ch.HobbyId
            });
            modelBuilder.Entity<Customer_Technology>().HasKey(ct => new
            {
                ct.CustomerId,
                ct.TechnologyId
            });
            modelBuilder.Entity<Customer_Channel>().HasKey(cch => new
            {
                cch.CustomerId,
                cch.ChannelId
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);
            modelBuilder.Entity<Customer_Criteria>().HasOne(m => m.Customer).WithMany(cc => cc.Customers_Criterias).HasForeignKey(m => m.CustomerId);
            modelBuilder.Entity<Customer_Criteria>().HasOne(m => m.Criteria).WithMany(cc => cc.Customers_Criterias).HasForeignKey(m => m.CriteriaId);
            modelBuilder.Entity<Customer_Hobby>().HasOne(m => m.Customer).WithMany(ch => ch.Customers_Hobbies).HasForeignKey(m => m.CustomerId);
            modelBuilder.Entity<Customer_Hobby>().HasOne(m => m.Hobby).WithMany(ch => ch.Customers_Hobbies).HasForeignKey(m => m.HobbyId);
            modelBuilder.Entity<Customer_Technology>().HasOne(m => m.Customer).WithMany(ct => ct.Customers_Technologies).HasForeignKey(m => m.CustomerId);
            modelBuilder.Entity<Customer_Technology>().HasOne(m => m.Technology).WithMany(ct => ct.Customers_Technologies).HasForeignKey(m => m.TechnologyId);
            modelBuilder.Entity<Customer_Channel>().HasOne(m => m.Customer).WithMany(cch => cch.Customers_Channels).HasForeignKey(m => m.CustomerId);
            modelBuilder.Entity<Customer_Channel>().HasOne(m => m.Channel).WithMany(cch => cch.Customers_Channels).HasForeignKey(m => m.ChannelId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<Criteria> Criterias { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Customer_Criteria> Customers_Criterias { get; set; }
        public DbSet<Customer_Hobby> Customers_Hobbies { get; set; }
        public DbSet<Customer_Technology> Customers_Technologies { get; set; }
        public DbSet<Customer_Channel> Customers_Channels { get; set; }





    }
}
