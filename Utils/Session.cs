using Recipe.Data;
using Recipe.Models;
using Recipe.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.Utils
{
    public static class Session
    {
        private static RecipeContext _context = new RecipeContext();

        public static UserRepo userRepo = new UserRepo(_context);
        public static RecipeRepo recipeRepo = new RecipeRepo(_context);

    }
}
