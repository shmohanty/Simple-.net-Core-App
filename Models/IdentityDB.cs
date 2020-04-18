
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CCMSample.Models
{
    public class IdentityDB : IdentityDbContext<IdentityUser>
    {
        public IdentityDB(DbContextOptions<IdentityDB> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
