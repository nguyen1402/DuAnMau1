using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBH.entities;

namespace DAL_QLBH.IDALService
{
    public interface ISeviceLichsu
    {
        public List<Lichsu> getLichsus();
        public void GetlslichsufromDB();
        public bool Add(Lichsu lichsu);
        public bool Update(Lichsu lichsu);
    }
}
