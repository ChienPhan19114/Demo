using Microsoft.EntityFrameworkCore;
using Demo.Models;

namespace Demo.Data
{
    public class ChiTietHDContext : DbContext
    {
        public ChiTietHDContext(DbContextOptions<ChiTietHDContext> options)
            : base(options) { }
        public DbSet<ChiTietHD> ChiTietHDs { get; set; }
    }
}
