using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBH.Databasecontext;
using DAL_QLBH.entities;
using DAL_QLBH.IDALService;

namespace DAL_QLBH.DALService
{
   public class SeviceLichsu :ISeviceLichsu
   {
       private Database_Poly _db;
       private List<Lichsu> _lsLichsus;
        public SeviceLichsu()
        {
            _db = new Database_Poly();
            _lsLichsus = new List<Lichsu>();
            GetlslichsufromDB();
        }
        public List<Lichsu> getLichsus()
        {
            return _lsLichsus;
        }

        public void GetlslichsufromDB()
        {
            _lsLichsus = _db.Lichsus.ToList();
        }

        public bool Add(Lichsu lichsu)
        {
            _lsLichsus.Add(lichsu);
            _db.Lichsus.Add(lichsu);
            _db.SaveChanges();
            return true;
        }

        public bool Update(Lichsu lichsu)
        {
            _db.Lichsus.Update(lichsu);
            _db.SaveChanges();
            return true;
        }
    }
}
