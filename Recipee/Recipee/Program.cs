using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recipe
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new Database();
            //Register user 
            var user = new Users("Lulu", "Lulu@gmail.com", "Password");
            database.RegisterUser(user);
            //Submit  recipe
            var recipe = new Recipe_Sharing("Chicken vegetables", "Boil chicken and vegetabls","Chicken vegetables", "Boil chicken and vegetabls");
            
            database.SubmitRecipe(recipe);

            //Rate recipe
            database.RateRecipe(0,5);

            Console.WriteLine("Recipe rated successfully!");
        }
        }
    }

