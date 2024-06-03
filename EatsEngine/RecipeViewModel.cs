using System.Collections.ObjectModel;
using System.ComponentModel;

namespace EatsEngine
{
    public class RecipeViewModel
    {
        public ObservableCollection<Recipe> Recipes { get; set; }

        public RecipeViewModel()
        {
            Recipes = new ObservableCollection<Recipe>()
            {
                new Recipe 
                { 
                    Name = "Pasta Carbonara", 
                    Description = "Creamy pasta with pancetta", 
                    ImagePath="/assets/images/Pasta_Carbonara.jpg", 
                    CookTime="25 minutes" 
                },
                new Recipe 
                { 
                    Name = "Margherita Pizza", 
                    Description = "Simple pizza with tomatoes, fresh mozzarella, and basil", 
                    ImagePath="/assets/images/Margherita_Pizza.jpg", 
                    CookTime="15 minutes" 
                }
            };
        }
    }

    public class Recipe
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public string CookTime { get; set; } = string.Empty;
    }

}
