using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using BUS_QLBH.Iservice;
using DAL_QLBH.DalIService;
using DAL_QLBH.DaLService;
using DAL_QLBH.entities;
using System.IO;

namespace BUS_QLBH.Service
{
    public class ServiceSanPhambus : IServiceSanPhambus
    {
        private ISeviceSanPham _iSeviceSanPham;
        private List<Hang> _lsHangs;
        public ServiceSanPhambus()
        {
            _iSeviceSanPham = new SeviceSanPham();
            _lsHangs = new List<Hang>();
            GetHangfromDB();
        }
        public string Them(Hang sp)
        {
            return _iSeviceSanPham.AddHang(sp);
        }
        public string Sua(Hang sp)
        {
            return _iSeviceSanPham.Updatehang(sp);
        }

        public string Xoa(string temp)
        {
            var ma = _lsHangs.Where(c => c.MaHang == temp).FirstOrDefault();
            return _iSeviceSanPham.DeleteHang(ma);
        }

        public List<Hang> GetlsHangs()
        {
            return _lsHangs;
        }

        public void GetHangfromDB()
        {
            _lsHangs = _iSeviceSanPham.Getlisthang();
        }

        public List<Hang> TimKiem(string acc)
        {
            return _lsHangs.Where(c => c.TenHang.StartsWith(acc)).ToList();
        }
    }
}
