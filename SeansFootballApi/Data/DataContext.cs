using Microsoft.EntityFrameworkCore;
using SeansFootballApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeansFootballApi.Data
{
    public class DataContext : DbContext
    {
        public DbSet<FighterDetails> FighterDetails { get; set; }
        public DbSet<P4PRankings> P4PRankings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True");
        }
    }

}
