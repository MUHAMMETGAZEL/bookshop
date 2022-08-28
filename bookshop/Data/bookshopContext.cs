using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bookshop.Models;

namespace bookshop.Data
{
    public class bookshopContext : DbContext
    {
        public bookshopContext (DbContextOptions<bookshopContext> options)
            : base(options)
        {
        }

        public DbSet<bookshop.Models.book> book { get; set; } = default!;

        public DbSet<bookshop.Models.usersaccounts>? usersaccounts { get; set; }

        public DbSet<bookshop.Models.orders>? orders { get; set; }
        public DbSet<bookshop.Models.report>? reprot { get; set; }
    }
}
