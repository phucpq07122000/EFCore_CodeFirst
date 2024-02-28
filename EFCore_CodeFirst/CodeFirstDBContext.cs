using EFCore_CodeFirst.Enitity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EFCore_CodeFirst
{
    public class CodeFirstDBContext : DbContext
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<UserDetail>? UserDetails { get; set; }
        public DbSet<UserOrder>? UserOrders { get; set; }
        public DbSet<UserOrderProduct>? userOrderProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=ep-crimson-breeze-a1kxgcsp.ap-southeast-1.aws.neon.tech;Database=MyWork1;Username=phucpq07122000;Password=pMG49dRqZQBf");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .HasOne(a => a.UserDetail)
                .WithOne(a => a.User)
                .HasForeignKey<UserDetail>(a => a.UserId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.UserOrders)
                .WithOne(o => o.User)
                .HasForeignKey(o => o.UserID);

            modelBuilder.Entity<UserOrder>()
                .HasMany(uop => uop.UserOrderProducts)
                .WithOne(p => p.UserOrder)
                .HasForeignKey(uop => uop.UserOrderId);

            modelBuilder.Entity<UserOrderProduct>()
                .HasOne(uop => uop.Products)
                .WithMany(p => p.userOrderProducts)
                .HasForeignKey(uop => uop.ProductId);




        }

        
       
    }

    
}
