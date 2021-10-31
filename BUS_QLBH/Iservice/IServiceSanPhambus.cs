using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBH.entities;

namespace BUS_QLBH.Iservice
{
    public interface IServiceSanPhambus
    {
        public string Them(Hang sp);
        public string Sua(Hang sp);
        public string Xoa(string temp);
        public List<Hang> GetlsHangs();
        public void GetHangfromDB();
        public List<Hang> TimKiem(string acc);
    }
}
