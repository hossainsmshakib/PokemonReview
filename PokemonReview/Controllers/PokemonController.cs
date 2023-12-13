using Microsoft.AspNetCore.Mvc;
using PokemonReview.Interfaces;

namespace PokemonReview.Controllers
{
    [Route("api/[controller])")]
    [ApiController]
    public class PokemonController
    {
        private readonly IPokemonRepository _pokemonRepository;
        public PokemonController(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }
    }
}
