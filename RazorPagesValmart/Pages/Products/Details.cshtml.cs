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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesValmart.Data.RazorPagesValmartContext _context;

        public DetailsModel(RazorPagesValmart.Data.RazorPagesValmartContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product.FirstOrDefaultAsync(m => m.ID == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
