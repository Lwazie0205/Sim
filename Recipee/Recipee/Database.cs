using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recipe
{
    class Database
    {
        public List<Users> users { get; set; }
        public List<Recipe_Sharing> Recipes { get; set; }
        public Database()
        {
            users = new List<Users>();
            Recipes = new List<Recipe_Sharing>();
        }
        public void RegisterUser(Users user)
        {
            users.Add(user);
        }
        public void SubmitRecipe(Recipe_Sharing recipe)
        {
            Recipes.Add(recipe);
        }
        public Recipe_Sharing GetRecipe(int id)
        {
            return Recipes.Find(r => r.Id == id);
        }
        public void RateRecipe(int id, int rating)
        {
            var recipe = GetRecipe(id);
            if (recipe != null)
            {
                recipe.Ratings.Add(rating);
            }
        }
    }
}

    

