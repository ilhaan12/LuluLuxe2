using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LuluLuxe.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        // Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet for Appointment (represents the Appointment table in the database)
        public DbSet<Appointment> Appointments { get; set; }

        // DbSet for Service (represents the Service table)
        public DbSet<Service> Services { get; set; }

        // DbSet for Staff (represents the Staff table for stylists)
        public DbSet<Staff> Staff { get; set; }

        // DbSet for Reviews (represents the Reviews table)
        public DbSet<Review> Reviews { get; set; }

        // DbSet for Payments (if you want to store payment records)
        public DbSet<Payment> Payments { get; set; }
    }
}

    