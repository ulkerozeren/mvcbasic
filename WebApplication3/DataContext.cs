using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3
{
    public class DataContext:DbContext
    {
        public DataContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            //DB BAĞLANTISI VB DATABASE INSTANCE'INI İLGİLENDİREN İNCE AYARLAR

            // dbContextOptionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ECommerce;Integrated Security=True");
            dbContextOptionsBuilder.UseSqlServer("Server=127.0.0.1;Database=Deneme;User=sa;Password=123;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<User> Users { get; set; }
      
    }
}
