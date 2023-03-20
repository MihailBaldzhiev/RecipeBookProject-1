using System;
using Recipe.Models;
using Recipe.Data;

namespace Recipe.Data
{
    public class RecipeLogic
    {
        private RecipeContext recipeContext;

        public RecipeLogic(RecipeContext recipeContext)
        {
            this.recipeContext = recipeContext;
        }

        public List<RecipeModel> GetAll()
        {
            return recipeContext.Recipes.ToList();
        }

        public void Add(RecipeModel recipe)
        {
            recipeContext.Recipes.Add(recipe);
            recipeContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = recipeContext.Recipes.Find(id);
            if (item != null)
            {
                recipeContext.Recipes.Remove(item);
                recipeContext.SaveChanges();
            }
        }
    }
}
