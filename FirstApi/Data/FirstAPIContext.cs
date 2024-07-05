using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstAPI.Models;

namespace FirstAPI.Data
{
    public class FirstAPIContext : DbContext
    {
        public FirstAPIContext (DbContextOptions<FirstAPIContext> options)
            : base(options)
        {
        }

        public DbSet<FirstAPI.Models.Cars> Cars { get; set; } = default!;
    }
}
