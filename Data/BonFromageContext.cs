using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BonFromage.Models;

namespace BonFromage.Data
{
    public class BonFromageContext : DbContext
    {
        public BonFromageContext (DbContextOptions<BonFromageContext> options)
            : base(options)
        {
        }

        public DbSet<BonFromage.Models.MenuItem> MenuItem { get; set; }
    }
}
