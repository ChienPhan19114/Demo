using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models
{
    public class SanPham
    {
        [Key]
        [Required]
        [StringLength(6)]
        public string MaSP { get; set; }
        [Required]
        [StringLength(50)]
        public string TenSp { get; set; }
        [StringLength(10)]
        public string DonViTinh { get; set; }
        [DataType(DataType.Currency)]
        [Range(0, int.MaxValue, ErrorMessage = "Phai la so duong.")]
        [RegularExpression(@"\d+(\.\d{0,2})?", ErrorMessage = "Toi da 2 chu so thap phan.")]
        public Double DonGia { get; set; }
    }
}
