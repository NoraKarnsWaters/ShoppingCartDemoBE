using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using backend;

namespace backend.Data
{
    public class backendContext : DbContext
    {
        public backendContext (DbContextOptions<backendContext> options)
            : base(options)
        {
        }

        public DbSet<backend.Book> Book { get; set; } = default!;

        public DbSet<backend.Cart>? Cart { get; set; }
    }
}
