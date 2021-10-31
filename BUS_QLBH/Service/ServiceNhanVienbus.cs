using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_QLBH.Iservice;
using DAL_QLBH.DalIService;
using DAL_QLBH.DaLService;
using DAL_QLBH.entities;

namespace BUS_QLBH.Service
{
    public class ServiceNhanVienbus : IServiceNhanVienbus
    {
        private ISeviceNhanVien _nhanVien;
        private List<NhanVien> _lstNhanViens;
        public ServiceNhanVienbus()
        {
            _nhanVien = new SeviceNhanVien();
            _lstNhanViens = new List<NhanVien>();
            getlistDB();
        }

        public NhanVien NhanVien(string email, string tenNv, string diaChi, int vaitro, bool tinhTrang , string matkhau)
        {
            NhanVien nv = new NhanVien();
            nv.Email = email;
            nv.TenNV = tenNv;
            nv.DiaChi = diaChi;
            nv.vaitro = vaitro;
            nv.Tinhtrang = tinhTrang;
            nv.Matkhau = matkhau;
            return nv;
        }

        public void getlistDB()
        {
            _lstNhanViens = _nhanVien.GetlsNhanViens();
        }
        public List<NhanVien> getlistNV()
        {
            return _lstNhanViens;
        }
        public string Them(NhanVien nv)
        {
            return _nhanVien.AddHang(nv);
        }
        public string Sua(NhanVien nv)
        {
            return _nhanVien.Updatehang(nv);
        }

        public string Xoa(int temp)
        {
            var nv = _nhanVien.GetlsNhanViens().Where(c => c.MaNV == temp).FirstOrDefault();
            return _nhanVien.DeleteHang(nv);
        }

        public List<NhanVien> TimKiem(string ten)
        {
            return _lstNhanViens.Where(c=>c.TenNV.Contains(ten)).ToList();
        }
    }
}
