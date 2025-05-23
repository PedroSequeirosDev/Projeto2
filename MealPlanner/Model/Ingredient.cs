using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlanner.Model
{
    public class Ingredient : IIngredient
    {
        public string Name { get; }
        public string Type { get; }

        public Ingredient(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public bool Equals(IIngredient other)
        {
            if (other == null)
                return false;

            return string.Equals(Name, other.Name) && string.Equals(Type, other.Type);

        }

    }

}