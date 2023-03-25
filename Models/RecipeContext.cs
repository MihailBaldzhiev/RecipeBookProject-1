using System;
using Recipe.Models;
using Microsoft.EntityFrameworkCore;

namespace Recipe.Models
{
    public class RecipeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectstring = "server=localhost;uid=root;pwd=NikolaY05$;database=RecipeDB;";
            optionsBuilder.UseMySql(connectstring, ServerVersion.AutoDetect(connectstring));
        }

        public DbSet<RecipeModel> Recipes { get; set; }
        public DbSet<UserModel> Users { get; set; }
    }
}
