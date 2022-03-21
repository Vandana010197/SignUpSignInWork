using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class ManageDbContext :DbContext
    {
        public ManageDbContext(DbContextOptions<ManageDbContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<VerifyAccount> VerifyAccounts { get; set; }

    }
}
