using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlanner.Model
{
    public class Recipe : IRecipe
    {
        public string Name { get; }
        public IReadOnlyDictionary<IIngredient, int> IngredientsNeeded { get; }

        public double SuccessRate { get; }

        /// this class implements IRecipe and makes so the recipes are ordered alphabetically

        public Recipe(string name, IReadOnlyDictionary<IIngredient, int> ingredientsNeeded, double successRate)
        {
            Name = name;
            IngredientsNeeded = ingredientsNeeded;
            SuccessRate = successRate;
        }

        public int CompareTo(IRecipe other)
        {
            if (other == null)
                return 1;

            else
            {
                return string.Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase);
            }
        }
    }
}