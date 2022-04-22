using Microsoft.EntityFrameworkCore;
using SampleWebStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SampleWebStudent.Entities
{
    public class RepositoriesContext : DbContext
    {
        public RepositoriesContext(DbContextOptions options) : base(options) { }

        public DbSet<Student> Products { get; set; }
        public object Student { get; internal set; }
    }
}
