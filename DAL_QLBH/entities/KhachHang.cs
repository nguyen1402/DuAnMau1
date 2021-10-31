using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBH.entities
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        public Guid MaKH { get; set; }
        [Required]
        public string TenKhach { get; set; }
        [StringLength(28)]
        [Required]
        public string Diachi { get; set; }
        [Required]
        public int Phai { get; set; }
        [Required]
        public string SDtKH { get; set; }
        [StringLength(15)]
        [Required]
        [ForeignKey("NhanVien")]//Tên khóa phụ
        public int MaNV { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
