using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class NhanVien
    {
        [Key]
        [Required]
        [StringLength(6)]
        public string MaNV { get; set; }
        [Required]
        [StringLength(30)]
        public string HoNV { get; set; }
        [Required]
        [StringLength(12)]
        public string TenNV { get; set; }
        public Boolean GioiTinh { get; set; }
            
        [Required]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgaySinh { get; set; }
        [StringLength(50)]
        public string DiaChi { get; set; } 
        [StringLength(10)]
        public string DienThoai { get; set; }
    }
}
