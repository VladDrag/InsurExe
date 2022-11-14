using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InsurExeApi.Models.DatabaseModels;

    public class InsuranceContext : DbContext
    {
        public InsuranceContext (DbContextOptions<InsuranceContext> options)
            : base(options)
        {
        }

        public DbSet<InsurExeApi.Models.DatabaseModels.InsuranceDb> InsuranceDb { get; set; } = default!;
    }
