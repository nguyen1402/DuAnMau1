using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBH.DalIService;
using DAL_QLBH.Databasecontext;
using DAL_QLBH.entities;
using Microsoft.EntityFrameworkCore;

namespace DAL_QLBH.DaLService
{
    public class SeviceSanPham : ISeviceSanPham
    {
        private List<Hang> _lstHangs;
        private Database_Poly _dbContext;

        public SeviceSanPham()
        {
            _lstHangs = new List<Hang>();
            _dbContext = new Database_Poly();
            GetlistformDB();
        }

        public void GetlistformDB()
        {
            _lstHangs = _dbContext.Hangs.ToList();
        }

        public List<Hang> Getlisthang()
        {
            return _lstHangs;
        }
        public string AddHang(Hang hang)
        {
            _lstHangs.Add(hang);
            _dbContext.Add(hang);
            _dbContext.SaveChanges();
            return "Thêm thành công";
        }
        public string Updatehang(Hang hang)
        {
            _dbContext.Update(hang);
            _dbContext.SaveChanges();
            return "Sửa thành công";
        }
        public string DeleteHang(Hang hang)
        {
            _lstHangs.RemoveAt(_lstHangs.FindIndex(c => c.MaHang == hang.MaHang));
            _dbContext.Remove(hang);
            _dbContext.SaveChanges();
            return "Xóa thành công";
        }
    }
}
