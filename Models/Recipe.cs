using System;

namespace Recipe.Models
{
    public class RecipeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Instructions { get; set; }
        public int TimeRequired { get; set; }
    }
}
