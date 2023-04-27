using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAndDbSample.Models;

namespace WebAndDbSample.Data
{
    public class WebAndDbSampleContext : DbContext
    {
        public WebAndDbSampleContext (DbContextOptions<WebAndDbSampleContext> options)
            : base(options)
        {
        }

        public DbSet<WebAndDbSample.Models.Blog> Blog { get; set; } = default!;
    }
}
