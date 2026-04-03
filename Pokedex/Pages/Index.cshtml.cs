using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pokedex.Data;
using Pokedex.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pokedex.Pages
{
    public class IndexModel : PageModel
    {
        public List<Pokemon> PokemonList { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Search { get; set; }

        public void OnGet()
        {
            var allPokemon = PokemonRepository.GetAll();
            if (!string.IsNullOrWhiteSpace(Search))
            {
                PokemonList = allPokemon
                    .Where(p => p.Name.ToLower().Contains(Search.ToLower()))
                    .ToList();
            }
            else
            {
                PokemonList = allPokemon;
            }
        }
    }
}
