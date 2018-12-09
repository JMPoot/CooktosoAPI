using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CooktosoAPI.Models
{
    public class Recipe
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}
