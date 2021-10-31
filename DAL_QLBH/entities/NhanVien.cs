using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBH.entities
{
    [Table("Nhanvien")]
    public class NhanVien
    {
        [Key]
        public int MaNV { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string TenNV { get; set; }
        [Required]
        public string DiaChi { get; set; }
        [Required]
        public int vaitro { get; set; }
        [Required]
        public bool Tinhtrang { get; set; }
        [Required]
        public string Matkhau { get; set; }
        public ICollection<Hang> Hangs { get; set; }
        public ICollection<KhachHang> KhachHangs { get; set; }
    }
}
