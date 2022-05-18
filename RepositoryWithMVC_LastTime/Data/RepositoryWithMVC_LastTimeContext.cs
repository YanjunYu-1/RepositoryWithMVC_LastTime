using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepositoryWithMVC_LastTime.Models;

namespace RepositoryWithMVC_LastTime.Data
{
    public class RepositoryWithMVC_LastTimeContext : DbContext
    {
        public RepositoryWithMVC_LastTimeContext (DbContextOptions<RepositoryWithMVC_LastTimeContext> options)
            : base(options)
        {
        }

        public DbSet<RepositoryWithMVC_LastTime.Models.Account> Account { get; set; }

        public DbSet<RepositoryWithMVC_LastTime.Models.Customer> Customer { get; set; }
    }
}
