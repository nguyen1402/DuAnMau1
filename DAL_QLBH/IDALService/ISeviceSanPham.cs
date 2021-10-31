using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBH.Databasecontext;
using DAL_QLBH.entities;

namespace DAL_QLBH.DalIService
{
    public interface ISeviceSanPham
    {
        public void GetlistformDB();
        public List<Hang> Getlisthang();
        public string AddHang(Hang hang);
        public string Updatehang(Hang hang);
        public string DeleteHang(Hang hang);
    };
}
