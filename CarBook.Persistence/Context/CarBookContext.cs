using Microsoft.EntityFrameworkCore;
using CarBook.Domain.Entities;

namespace CarBook.Persistence.Context
{
    public class CarBookContext : DbContext
    {
        public CarBookContext(DbContextOptions<CarBookContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS04;initial Catalog=CarBookDb; integrated security=true; trustservercertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Reservation - Location iliþkisi (PickUp)
            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.PickUpLocation)
                .WithMany(l => l.PickUpReservation)
                .HasForeignKey(r => r.PickUpLocationID)
                .OnDelete(DeleteBehavior.Restrict);

            // Reservation - Location iliþkisi (DropOff)
            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.DropOffLocation)
                .WithMany(l => l.DropOffReservation)
                .HasForeignKey(r => r.DropOffLocationID)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDescription> CarDescriptions { get; set; }
        public DbSet<CarFeature> CarFeatures { get; set; }
        public DbSet<CarPricing> CarPricings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FooterAddress> FooterAddresses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
