using Microsoft.VisualBasic.ApplicationServices;
using Recipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.Repositories
{
    public class UserRepo
    {
        private RecipeContext recipeContext;
        public UserRepo(RecipeContext recipeContext)
        {
            this.recipeContext = recipeContext;
    }

        public List<UserModel> GetAll()
        {
            return recipeContext.Users.ToList();
        }

        public void AddUser(UserModel user)
        {
            recipeContext.Users.Add(user);
            recipeContext.SaveChanges();
        }

        public void DeleteUser(UserModel item)
        {
            recipeContext.Users.Remove(item);
            recipeContext.SaveChanges();
        }

        public UserModel Find(int id)
        {
            return recipeContext.Users.Find(id);
        }
    }
}
