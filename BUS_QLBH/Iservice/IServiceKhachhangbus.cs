using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBH.entities;

namespace BUS_QLBH.Iservice
{
    public interface IServiceKhachhangbus
    {
        public void getlsfromDB();
        public List<KhachHang> getlistKH();
        public string Them(KhachHang nv);
        public string Sua(KhachHang nv);
        public string Xoa(Guid temp);

        public List<KhachHang> Timkiem(string acc);
    }
}
