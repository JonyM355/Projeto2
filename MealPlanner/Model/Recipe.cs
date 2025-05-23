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

        public int CompareTo(IRecipe other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}