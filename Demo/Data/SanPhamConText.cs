using Microsoft.EntityFrameworkCore;
using Demo.Models;

namespace Demo.Data
{
    public class SanPhamContext : DbContext
    {
        public SanPhamContext(DbContextOptions<SanPhamContext> options)
            : base(options) { }
        public DbSet<SanPham> SanPhams { get; set; }
    }
}
