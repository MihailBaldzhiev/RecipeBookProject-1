using System;
using Recipe.Models;
using Microsoft.EntityFrameworkCore;

namespace Recipe.Models
{
    public class UserContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectstring = "server=localhost;uid=root;pwd=root;database=RecipeDB;";
            optionsBuilder.UseMySql(connectstring, ServerVersion.AutoDetect(connectstring));
        }

        public DbSet<UserModel> Users { get; set; }
    }
}
