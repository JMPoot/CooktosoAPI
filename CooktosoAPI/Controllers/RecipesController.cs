using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CooktosoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CooktosoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : Controller
    {
        private readonly CooktosoContext _context;

        public RecipesController(CooktosoContext context)

        {
            _context = context;
            List<Ingredient> ingredients = new List<Ingredient>();
            Ingredient ingredient = new Ingredient
            {
                Name = "Broodt"
            };
            ingredients.Add(ingredient);


            if (_context.Recipes.Count() == 0)
            {
                _context.Recipes.Add(new Recipe { Name = "Recipe 1", Ingredients = ingredients });
                _context.SaveChanges();
            }
        }

        public async Task<ActionResult<IEnumerable<Recipe>>> GetRecipes()
        {
            return await _context.Recipes.ToListAsync();
        }
    }
}
