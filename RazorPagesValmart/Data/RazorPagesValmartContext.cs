using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesValmart.Models;

namespace RazorPagesValmart.Data
{
    public class RazorPagesValmartContext : DbContext
    {
        public RazorPagesValmartContext (DbContextOptions<RazorPagesValmartContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesValmart.Models.Product> Product { get; set; }
    }
}
