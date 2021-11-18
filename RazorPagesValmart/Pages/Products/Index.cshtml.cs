using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesValmart.Data;
using RazorPagesValmart.Models;

namespace RazorPagesValmart.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesValmart.Data.RazorPagesValmartContext _context;

        public IndexModel(RazorPagesValmart.Data.RazorPagesValmartContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
