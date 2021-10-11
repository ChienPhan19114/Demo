using Microsoft.EntityFrameworkCore;
using Demo.Models;

namespace Demo.Data
{
    public class KhachHangContext : DbContext
    {
        public KhachHangContext(DbContextOptions<KhachHangContext> options)
            : base(options) { }
        public DbSet<KhachHang> KhachHangs { get; set; }
    }
}
