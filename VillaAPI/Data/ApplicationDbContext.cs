using Microsoft.EntityFrameworkCore;
using VillaAPI.Models;

namespace VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Donec massa sapien, pharetra eget semper vel, sagittis at mi. Sed euismod venenatis dictum. Donec at neque ut risus tincidunt malesuada ut ut enim. Vivamus vitae tincidunt leo. Integer eu.",
                    Rate = 200,
                    Occupancy = 5,
                    Sqft = 550,
                    ImageUrl = "",
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Premium Pool Villa",
                    Details = "Donec massa sapien, pharetra eget semper vel, sagittis at mi. Sed euismod venenatis dictum. Donec at neque ut risus tincidunt malesuada ut ut enim. Vivamus vitae tincidunt leo. Integer eu.",
                    Rate = 300,
                    Occupancy = 4,
                    Sqft = 550,
                    ImageUrl = "",
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 3,
                    Name = "Luxury Pool Villa",
                    Details = "Donec massa sapien, pharetra eget semper vel, sagittis at mi. Sed euismod venenatis dictum. Donec at neque ut risus tincidunt malesuada ut ut enim. Vivamus vitae tincidunt leo. Integer eu.",
                    Rate = 400,
                    Occupancy = 4,
                    Sqft = 750,
                    ImageUrl = "",
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 4,
                    Name = "Diamond Villa",
                    Details = "Donec massa sapien, pharetra eget semper vel, sagittis at mi. Sed euismod venenatis dictum. Donec at neque ut risus tincidunt malesuada ut ut enim. Vivamus vitae tincidunt leo. Integer eu.",
                    Rate = 550,
                    Occupancy = 4,
                    Sqft = 900,
                    ImageUrl = "",
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 5,
                    Name = "Diamond Pool Villa",
                    Details = "Donec massa sapien, pharetra eget semper vel, sagittis at mi. Sed euismod venenatis dictum. Donec at neque ut risus tincidunt malesuada ut ut enim. Vivamus vitae tincidunt leo. Integer eu.",
                    Rate = 600,
                    Occupancy = 4,
                    Sqft = 1100,
                    ImageUrl = "",
                    Amenity = "",
                    CreatedDate = DateTime.Now
                }
            );
        }
    }
}
