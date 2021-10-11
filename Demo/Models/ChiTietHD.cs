using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Demo.Models
{
    public class ChiTietHD
    {
        [ForeignKey("MaKH")]
        [Required]
        public string MaKH { get; set; }
        [ForeignKey("MaSP")]
        [Required]
        [StringLength(6)]
        public string MaSP { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Phai la so duong")]
        public int SoLuong { get; set; }
    }
}
