using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tudose_Nicholas_Lab3.Models;

namespace Tudose_Nicholas_Lab3.Data
{
    public class Tudose_Nicholas_Lab3Context : DbContext
    {
        public Tudose_Nicholas_Lab3Context (DbContextOptions<Tudose_Nicholas_Lab3Context> options)
            : base(options)
        {
        }

        public DbSet<Tudose_Nicholas_Lab3.Models.Book> Book { get; set; } = default!;
        public DbSet<Tudose_Nicholas_Lab3.Models.Publisher> Publisher { get; set; } = default!;
        public IEnumerable Authors { get; internal set; }
        public DbSet<Tudose_Nicholas_Lab3.Models.Author> Author { get; set; } = default!;
    }
}
