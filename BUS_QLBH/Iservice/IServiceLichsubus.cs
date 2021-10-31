using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBH.entities;

namespace BUS_QLBH.Iservice
{
   public interface IServiceLichsubus
    {
        public List<Lichsu> getLichsus();
        public void GetlslichsufromDB();
        public bool Add(Lichsu lichsu);
        public bool Update(Lichsu lichsu);
    }
}
