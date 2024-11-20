using bai2api.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace bai2api.DataContext
{

 public class AppDbContext : DbContext
        {
            public AppDbContext()
            {

            }
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

            public DbSet<DuAn> DuAns { get; set; }
            public DbSet<NhanVien> NhanViens { get; set; }
   
        public DbSet<PhanCong> PhanCongs { get; set; }
        }
    }

