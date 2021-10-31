using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBH.entities;

namespace DAL_QLBH.DalIService
{
    public interface ISeviceNhanVien
    {
        public string DeleteHang(NhanVien nv);
        public string Updatehang(NhanVien nv);
        public string AddHang(NhanVien nv);
        public List<NhanVien> GetlsNhanViens();
        public void GetlistformDBH();
    }
}
