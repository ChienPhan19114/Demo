using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class KhachHang
    {
        [Key]
        [Required]
        [StringLength(6)]
        public string MaKH { get; set; }
        [Required]
        [StringLength(40)]
        public string HoTenKH { get; set; }
        [StringLength(50)]
        public string DiaChi { get; set; }
        [StringLength(10)]
        public string DienThoai { get; set; }
    }
}
