using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
            IngredientsNeeded.Sort();
            return this.Name.CompareTo(other.Name);
        }
    }
}