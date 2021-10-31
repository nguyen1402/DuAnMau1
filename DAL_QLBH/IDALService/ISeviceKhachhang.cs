using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBH.entities;

namespace DAL_QLBH.DalIService
{
    public interface ISeviceKhachhang
    {
        public void GetlistformDBkH();
        public List<KhachHang> Getlistkhachhang();
        public string AddKhachHang(KhachHang kh);
        public string UpdateKhachhang(KhachHang kh);
        public string DeleteKhachHang(KhachHang id);
    }
}
