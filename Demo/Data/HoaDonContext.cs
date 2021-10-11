using Microsoft.EntityFrameworkCore;
using Demo.Models;

namespace Demo.Data
{
    public class HoaDonContext : DbContext
    {
        public HoaDonContext(DbContextOptions<HoaDonContext> options)
            : base(options) { }
        public DbSet<HoaDon> HoaDons { get; set; }
    }
}
