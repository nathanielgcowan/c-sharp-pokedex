using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pokedex.Data;
using Pokedex.Models;

namespace Pokedex.Pages
{
    public class DetailsModel : PageModel
    {
        public Pokemon Pokemon { get; set; }

        public void OnGet(int id)
        {
            Pokemon = PokemonRepository.GetById(id);
        }
    }
}
