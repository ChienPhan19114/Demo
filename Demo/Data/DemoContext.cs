using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Demo.Models;

namespace Demo.Data
{
    public class DemoContext : DbContext
    {
        public DemoContext (DbContextOptions<DemoContext> options)
            : base(options)
        {
        }

        public DbSet<Demo.Models.NhanVien> NhanVien { get; set; }

        public DbSet<Demo.Models.KhachHang> KhachHang { get; set; }

        public DbSet<Demo.Models.HoaDon> HoaDon { get; set; }

        public DbSet<Demo.Models.SanPham> SanPham { get; set; }
    }
}
