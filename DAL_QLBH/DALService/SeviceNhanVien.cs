using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBH.DalIService;
using DAL_QLBH.Databasecontext;
using DAL_QLBH.entities;
using Newtonsoft.Json.Linq;

namespace DAL_QLBH.DaLService
{
    public class SeviceNhanVien : ISeviceNhanVien
    {
        private List<NhanVien> _lstnhanvien;
        private Database_Poly _dbContext;

        public SeviceNhanVien()
        {
            _lstnhanvien = new List<NhanVien>();
            _dbContext = new Database_Poly();
            GetlistformDBH();
        }

        public void GetlistformDBH()
        {
            _lstnhanvien = _dbContext.NhanViens.ToList();
        }

        public List<NhanVien> GetlsNhanViens()
        {
            return _lstnhanvien;
        }
        public string AddHang(NhanVien nv)
        {
            _lstnhanvien.Add(nv);
            _dbContext.Add(nv);
            _dbContext.SaveChanges();
            return "Thêm thành công";
        }
        public string Updatehang(NhanVien nv)
        {
            _dbContext.Update(nv);
            _dbContext.SaveChanges();
            return "Sửa thành công";
        }
        public string DeleteHang(NhanVien nv)
        {
            _lstnhanvien.RemoveAt(_lstnhanvien.FindIndex(c => c.MaNV == nv.MaNV));
            _dbContext.Remove(nv);
            _dbContext.SaveChanges();
            return "Xóa thành công";
        }
        
    }
}
