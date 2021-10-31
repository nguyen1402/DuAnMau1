using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_QLBH.Iservice;
using DAL_QLBH.entities;
using DAL_QLBH.IDALService;

namespace BUS_QLBH.Service
{
   public class SeviceLichsu :IServiceLichsubus
   {
       private ISeviceLichsu _iLichsu;
       private List<Lichsu> _lsLichsus;
        public SeviceLichsu()
        {
            _iLichsu = new DAL_QLBH.DALService.SeviceLichsu();
            _lsLichsus = new List<Lichsu>();
            GetlslichsufromDB();
        }
        public List<Lichsu> getLichsus()
        {
            return _lsLichsus;
        }

        public void GetlslichsufromDB()
        {
            _lsLichsus = _iLichsu.getLichsus();
        }

        public bool Add(Lichsu lichsu)
        {
            return _iLichsu.Add(lichsu);
        }

        public bool Update(Lichsu lichsu)
        {
            return _iLichsu.Update(lichsu);
        }
    }
}
