using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Costea_Cosmina_lab8.Models;

namespace Costea_Cosmina_lab8.Data
{
    public class Costea_Cosmina_lab8Context : DbContext
    {
        public Costea_Cosmina_lab8Context (DbContextOptions<Costea_Cosmina_lab8Context> options)
            : base(options)
        {
        }
        public DbSet<Costea_Cosmina_lab8.Models.Book> Book { get; set; }
        public DbSet<Costea_Cosmina_lab8.Models.Category> Category { get; set; }
        public DbSet<Costea_Cosmina_lab8.Models.BookCategory> BookCategory { get; set; }
        public DbSet<Costea_Cosmina_lab8.Models.Publisher> Publisher { get; set; }
    }
}
