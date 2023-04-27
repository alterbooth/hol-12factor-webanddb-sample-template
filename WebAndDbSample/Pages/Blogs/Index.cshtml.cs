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
    public class IndexModel : PageModel
    {
        private readonly WebAndDbSample.Data.WebAndDbSampleContext _context;

        public IndexModel(WebAndDbSample.Data.WebAndDbSampleContext context)
        {
            _context = context;
        }

        public IList<Blog> Blog { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Blog != null)
            {
                Blog = await _context.Blog.ToListAsync();
            }
        }
    }
}
