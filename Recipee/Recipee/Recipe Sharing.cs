using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recipe
{
   class Recipe_Sharing
    {
       public int Id {get; set;}
       public string Title { get; set; }
     public string Description {get; set;}
    public string Ingredients {get; set;}
    public string Instructions { get; set; }
    public List<int> Ratings { get; set; }

    public Recipe_Sharing(string title, string description, string ingredients, string instructions)
    {
        Title = title;
        Description = description;
        Ingredients = ingredients;
        Instructions = instructions;
        Ratings = new List<int>();
    }


    }
}
