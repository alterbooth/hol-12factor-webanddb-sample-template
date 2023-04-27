using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAndDbSample.Data;
using WebAndDbSample.Models;

namespace WebAndDbSample.Pages.Blogs
{
    public class DetailsModel : PageModel
    {
        private readonly WebAndDbSample.Data.WebAndDbSampleContext _context;

        public DetailsModel(WebAndDbSample.Data.WebAndDbSampleContext context)
        {
            _context = context;
        }

      public Blog Blog { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Blog == null)
            {
                return NotFound();
            }

            var blog = await _context.Blog.FirstOrDefaultAsync(m => m.Id == id);
            if (blog == null)
            {
                return NotFound();
            }
            else 
            {
                Blog = blog;
            }
            return Page();
        }
    }
}
