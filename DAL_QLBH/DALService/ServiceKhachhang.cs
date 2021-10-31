using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBH.DalIService;
using DAL_QLBH.Databasecontext;
using DAL_QLBH.entities;

namespace DAL_QLBH.DaLService
{
    public class ServiceKhachhang : ISeviceKhachhang
    {
        private List<KhachHang> _lstkhachhang;
        private Database_Poly _dbContext;

        public ServiceKhachhang()
        {
            _lstkhachhang = new List<KhachHang>();
            _dbContext = new Database_Poly();
            GetlistformDBkH();
        }

        public void GetlistformDBkH()
        {
            _lstkhachhang = _dbContext.KhachHangs.ToList();
        }

        public List<KhachHang> Getlistkhachhang()
        {
            return _lstkhachhang;
        }


        public string AddKhachHang(KhachHang kh)
        {
            _lstkhachhang.Add(kh);
            _dbContext.Add(kh);
            _dbContext.SaveChanges();
            return "Thêm thành công";
        }
        public string UpdateKhachhang(KhachHang kh)
        {
            _dbContext.Update(kh);
            _dbContext.SaveChanges();
            return "Sửa thành công";
        }
        public string DeleteKhachHang(KhachHang id)
        {
            _lstkhachhang.RemoveAt(_lstkhachhang.FindIndex(c => c.MaKH == id.MaKH));
            _dbContext.Remove(id);
            _dbContext.SaveChanges();
            return "Xóa thành công";
        }
    }
}
