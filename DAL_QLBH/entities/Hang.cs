using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBH.entities
{
    [Table("Hang")]
    public class Hang
    {
        [Key]
        public string MaHang { get; set; }
        [StringLength(28)]
        [Required]
        public string TenHang { get; set; }
        [StringLength(28)]
        [Required]
        public int SoLuong { get; set; }
        [Required]
        public float Dgiaban { get; set; }
        [Required]
        public float Dgianhap { get; set; }
        [Required]
        public string GhiChu { get; set; }
        [Required]
        public byte[] Hinhanh { get; set; }
        [Required]
        [ForeignKey("NhanVien")]//Tên khóa phụ
        public int MaNV { get; set; }

        public NhanVien NhanVien { get; set; }

    }
}
