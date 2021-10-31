using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBH.entities;
using Microsoft.EntityFrameworkCore;

namespace DAL_QLBH.Databasecontext
{
    class Database_Poly: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("Data Source=DESKTOP-NPEJLEB\\SQLEXPRESS;Initial Catalog=DAM3;User ID=btn1;Password=123;MultipleActiveResultSets=True;Application Name=EntityFramework");
                }
            }

            public DbSet<NhanVien> NhanViens { get; set; }
            public DbSet<Hang> Hangs { get; set; }
            public DbSet<KhachHang> KhachHangs { get; set; }
            public DbSet<Lichsu> Lichsus { get; set; }

    }
}
