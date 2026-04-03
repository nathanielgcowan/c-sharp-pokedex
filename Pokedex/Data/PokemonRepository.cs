using System.Collections.Generic;
using Pokedex.Models;

namespace Pokedex.Data
{
    public static class PokemonRepository
    {
        public static List<Pokemon> GetAll()
        {
            return new List<Pokemon>
            {
                new Pokemon { Id = 1, Name = "Bulbasaur", Type = "Grass/Poison", ImageUrl = "/images/bulbasaur.png", Description = "A strange seed was planted on its back at birth." },
                new Pokemon { Id = 4, Name = "Charmander", Type = "Fire", ImageUrl = "/images/charmander.png", Description = "Obviously prefers hot places." },
                new Pokemon { Id = 7, Name = "Squirtle", Type = "Water", ImageUrl = "/images/squirtle.png", Description = "After birth, its back swells and hardens into a shell." }
                // Add more Pokémon as needed
            };
        }

        public static Pokemon GetById(int id)
        {
            return GetAll().Find(p => p.Id == id);
        }
    }
}
