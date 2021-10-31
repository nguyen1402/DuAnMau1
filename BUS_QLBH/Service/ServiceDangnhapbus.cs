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
    public class ServiceDangnhapbus : IServiceDangnhapbus
    {
        private IServiceNhanVienbus _iServiceNhanVienbus;
        public ServiceDangnhapbus()
        {
            _iServiceNhanVienbus = new ServiceNhanVienbus();
            
        }
        public bool Chuquan(string email, string mk)
        {
            var kq = _iServiceNhanVienbus.getlistNV().Where(c => c.Email == email && c.Matkhau == mk && c.vaitro == 0).ToList();
            if (kq.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Nhanvien(string email, string mk)
        {
            var kq = _iServiceNhanVienbus.getlistNV().Where(c => c.Email == email && c.Matkhau == mk && c.vaitro == 1).ToList();
            if (kq.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
