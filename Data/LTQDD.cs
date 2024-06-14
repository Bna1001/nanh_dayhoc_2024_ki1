using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using nanh_dayhoc_2024.Models;

    public class LTQDD : DbContext
    {
        public LTQDD (DbContextOptions<LTQDD> options)
            : base(options)
        {
        }

        public DbSet<nanh_dayhoc_2024.Models.LopHoc> LopHoc { get; set; } = default!;

        public DbSet<nanh_dayhoc_2024.Models.SinhVien> SinhVien { get; set; } = default!;
    }
