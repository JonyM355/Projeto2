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

        public bool Equals(IIngredient other)
        {
            if (other == null || GetType() != other.GetType()
                                && Name != other.Name)
            {
                return false;
            }

            return this.Name == other.Name && this.Type == other.Type;
        }
    }
}