using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_price_backend_database.Model
{
    public class HouseContext:DbContext
    {
        public HouseContext() { }
        public HouseContext(DbContextOptions<HouseContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<HouseDetails> HouseDetails { get; set; }
        public DbSet<Image>Images { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      => optionsBuilder.UseSqlServer("Server=AD-044\\SQLEXPRESS;Initial Catalog=House-Price-Set;Integrated Security=True;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true;");

    }
}
