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
    public class ServiceKhachhangbus : IServiceKhachhangbus
    {
        private ISeviceKhachhang _iSeviceKhachhang;
        private List<KhachHang> _lstKhachHangs;

        public ServiceKhachhangbus()
        {
            _iSeviceKhachhang = new ServiceKhachhang();
            _lstKhachHangs = _iSeviceKhachhang.Getlistkhachhang();
        }

        public void getlsfromDB()
        {
            _lstKhachHangs = new List<KhachHang>();
            _lstKhachHangs = _iSeviceKhachhang.Getlistkhachhang();
        }
        public List<KhachHang> getlistKH()
        {
            return _lstKhachHangs;
        }

        public string Them(KhachHang nv)
        {
            return _iSeviceKhachhang.AddKhachHang(nv);
        }
        public string Sua(KhachHang nv)
        {
            return _iSeviceKhachhang.UpdateKhachhang(nv);
        }

        public string Xoa(Guid temp)
        {
            var nv = _iSeviceKhachhang.Getlistkhachhang().Where(c => c.MaKH == temp).FirstOrDefault();
            return _iSeviceKhachhang.DeleteKhachHang(nv);

        }

        public List<KhachHang> Timkiem(string acc)
        {
            return _lstKhachHangs.Where(c=>c.TenKhach.Contains(acc)).ToList();
        }
    }
}
