using EFCore_CodeFirst.Enitity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_CodeFirst
{
    public class CodeFirstDBContext : DbContext
    {
        public DbSet<User>? Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=ep-crimson-breeze-a1kxgcsp.ap-southeast-1.aws.neon.tech;Database=MyWork1;Username=phucpq07122000;Password=pMG49dRqZQBf");
    }
}
