using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Context : DbContext
    {
        //3 paket yükledik bu katmanda.Tools,SqlServer,Efframeworkcore
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {   
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-CGLV6T1\TEW_SQLEXPRESS;Database=konsolkat;Trusted_Connection=True");
        }
        public DbSet<Product> Products{get;set;}
        public DbSet<Category> Categories{get;set;}
    }
}
