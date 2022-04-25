using Callers.Services;
using Microsoft.Extensions.Configuration;
using Model;
using Newtonsoft.Json;

namespace LogicMantle
{
    public class PokemonLogicMantle : BaseLogicMantle
    {

        public PokemonLogicMantle(IConfiguration configuration) : base(configuration) { }

        public async Task<Pokemon> GetPokemon(string pokemon)
        {

            if (pokemon == null || pokemon == "")
                return null;


            Pokemon poke = new Pokemon();


            PokemonService services = new PokemonService(Configuration);

            HttpResponseMessage response = await services.GetPokemon(pokemon);

            if (response.IsSuccessStatusCode)
            {

                var jsonResponse = await response.Content.ReadAsStringAsync();
                if(jsonResponse != null)
                    poke = JsonConvert.DeserializeObject<Pokemon>(jsonResponse);
            }

            return poke;

        }

    }
}