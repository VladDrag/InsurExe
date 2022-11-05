using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InsurExeApi.Models.DatabaseModels;

    public class InsuranceMovieContext : DbContext
    {
        public InsuranceMovieContext (DbContextOptions<InsuranceMovieContext> options)
            : base(options)
        {
        }

        public DbSet<InsurExeApi.Models.DatabaseModels.InsuranceDb> InsuranceDb { get; set; } = default!;
    }
