using System;
using Recipe.Models;
using Recipe.Data;
using Recipe.Repositories;
using Recipe.Utils;

namespace Recipe.Data
{
    public static class RecipeService
    {


        public static List<RecipeModel> GetAll()
        {
            return Session.recipeRepo.GetAll();
        }

        public static RecipeModel Get(string text)
        {
            RecipeModel result = Session.recipeRepo.Get(text);
            if (result == null)
            {
                throw new ArgumentNullException();
            }
            return result;

        }

        public static void Add(RecipeModel recipe)
        {
            Session.recipeRepo.Add(recipe);
        }

        public static void Delete(int id)
        {
            RecipeModel item = Session.recipeRepo.Find(id);
            if (item != null)
            {
                Session.recipeRepo.Delete(item.Id);
            }
        }
    }
}
