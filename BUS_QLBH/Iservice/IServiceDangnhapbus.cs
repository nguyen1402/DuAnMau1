using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBH.entities;

namespace BUS_QLBH.Iservice
{
    public interface IServiceDangnhapbus
    {
        public bool Chuquan(string email, string mk);
        public bool Nhanvien(string email, string mk);
    }
}
