using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBH.DalIService;
using DAL_QLBH.entities;

namespace BUS_QLBH.Iservice
{
    public interface IServiceNhanVienbus
    {
        public NhanVien NhanVien(string email, string tenNv, string diaChi, int vaitro, bool tinhTrang, string matkhau);
        public string Them(NhanVien nv);
        public string Sua( NhanVien nv);
        public string Xoa(int temp);
        public List<NhanVien> getlistNV();
        public void getlistDB();
        public List<NhanVien> TimKiem(string ten);
    }
}
