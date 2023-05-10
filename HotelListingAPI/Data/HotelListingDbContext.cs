using System;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;


namespace HotelListingAPI.Data
{
    public partial class HotelListingDbContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=hotellisting;User=root;Password=password1@;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM",
                },
                 new Country
                 {
                     Id = 2,
                     Name = "Bahamas",
                     ShortName = "BS",
                 },
                  new Country
                  {
                      Id = 3,
                      Name = "Cayman Islands",
                      ShortName = "CI",
                  }
             );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort and Spa",
                    Address = "Negril",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Comfort Suites",
                    Address = "George Town",
                    CountryId = 3,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Grand Pallidium",
                    Address = "Nassua",
                    CountryId = 2,
                    Rating = 4
                }

                );

        }

    }
}

