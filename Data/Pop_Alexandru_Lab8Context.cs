using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pop_Alexandru_Lab8.Models;

namespace Pop_Alexandru_Lab8.Data
{
    public class Pop_Alexandru_Lab8Context : DbContext
    {
        public Pop_Alexandru_Lab8Context (DbContextOptions<Pop_Alexandru_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Pop_Alexandru_Lab8.Models.Book> Book { get; set; }
    }
}
