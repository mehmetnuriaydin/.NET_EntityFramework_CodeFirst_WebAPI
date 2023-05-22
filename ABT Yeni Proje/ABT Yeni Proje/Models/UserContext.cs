using Microsoft.EntityFrameworkCore;

namespace ABT_Yeni_Proje.Models
{


    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<Activity>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<Activity>()
                .Property(a => a.UserId)
                .IsRequired();

            modelBuilder.Entity<User>()
                .HasMany(u => u.Activities)
                .WithOne()
                .HasForeignKey(a => a.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
    
