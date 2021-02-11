using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5CodeFirst.DataAccess
{

    //Add-Migration Net5CodeFirst.DataAccess.CustomDBContext
    //update-database
    // for a second migration : Add-Migration Net5CodeFirst.DataAccess.CustomDBContext_2
    // update-database
    public class CustomDBContext : DbContext
    {
        public CustomDBContext(DbContextOptions options)
            : base(options)
        {
        }
        public CustomDBContext()
        {

        }

        //we have to add this method
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["CustomDB"]);
            }
        }

        public DbSet<Students> Students { get; set; }

        public DbSet<Schools> Schools {get;set;}


    }
}
