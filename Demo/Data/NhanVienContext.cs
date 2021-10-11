using Microsoft.EntityFrameworkCore;
using Demo.Models;

namespace Demo.Data
{
    public class NhanVienContext : DbContext
    {
        public NhanVienContext(DbContextOptions<NhanVienContext> options)
            : base(options) { }
        public DbSet<NhanVien> NhanViens { get; set; }
    }
}
