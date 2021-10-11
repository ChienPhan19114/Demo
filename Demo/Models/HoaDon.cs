using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Demo.Models
{
    public class HoaDon
    {
        [Key]
        [Required]
        public int MaHD { get; set; }
        [Required]
        [StringLength(6)]
        public string MaKH { get; set; }
        [StringLength(6)]
        public string MaNV { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayLapHD { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayNhanHang { get; set; }
    }
}
