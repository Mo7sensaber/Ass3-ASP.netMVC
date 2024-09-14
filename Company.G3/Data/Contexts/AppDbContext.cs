using Company.G3.dal.Data.Configurations;
using Company.G3.dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Company.G3.dal.Data.Contexts
{
    public class AppDbContext:DbContext
    {
        private Assembly assembly;

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=Ass3Cor6;Trusted_Connection=True;TrustServerCertificate=True");

        //}
        public DbSet<Department> Departments { get; set; }
    }
}
