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
    public class DeleteModel : PageModel
    {
        private readonly WebAndDbSample.Data.WebAndDbSampleContext _context;

        public DeleteModel(WebAndDbSample.Data.WebAndDbSampleContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Blog == null)
            {
                return NotFound();
            }
            var blog = await _context.Blog.FindAsync(id);

            if (blog != null)
            {
                Blog = blog;
                _context.Blog.Remove(Blog);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
