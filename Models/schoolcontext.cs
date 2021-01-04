using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolMangmentSystemCore.Models
{
    public class schoolcontext:DbContext
    {
        public schoolcontext(DbContextOptions<schoolcontext> options)
            : base(options)

        {

        }
        public DbSet<student> students { get; set; }
        public DbSet<teacher> teachers { get; set; }
        public DbSet<subject> subjects { get; set; }
    }
}
