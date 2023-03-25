using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recipe.Models;
using Recipe.Data;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace Recipe.Repositories
{
    public class RecipeRepo

    {
        private RecipeContext recipeContext;

        public RecipeRepo(RecipeContext recipeContext)
        {
            this.recipeContext = recipeContext;
        }

        public List<RecipeModel> GetAll()
        {
            return recipeContext.Recipes.ToList();
        }

        public RecipeModel Get(string name) => GetAll().Find(x => x.Name.Contains(name));

        public void Add(RecipeModel recipe)
        {
            recipeContext.Recipes.Add(recipe);
            recipeContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = recipeContext.Recipes.Find(id);
            recipeContext.Recipes.Remove(item);
            recipeContext.SaveChanges();
            
        }

        public RecipeModel Find(int id)
        {
            return recipeContext.Recipes.Find(id);
        }
    }
}
