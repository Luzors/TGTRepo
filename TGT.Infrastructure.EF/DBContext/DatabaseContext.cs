using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGT.Infrastructure.EF.DBContext
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Package> Packages { get; set; }

        public DbSet<Cantine> Cantines { get; set; }

        public DbSet<Worker> Workers { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> contextOptions) : base(contextOptions) { }
    }

}