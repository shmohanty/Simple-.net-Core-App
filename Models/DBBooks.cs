using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CCMSample.Models
{
    public class DBBooks : DbContext
    {
        public DbSet<BookData> Books { get; set; }

        public DBBooks(DbContextOptions<DBBooks> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
