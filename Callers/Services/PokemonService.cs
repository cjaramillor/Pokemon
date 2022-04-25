using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callers.Services
{
    public class PokemonService
    {
        private readonly IConfiguration config;

        public PokemonService(IConfiguration config)
        {
            this.config = config;
        }


        public async Task<HttpResponseMessage> GetPokemon(string pokemon)
        {
            try
            {
                var url = config.GetSection("AppSettings")["PokeApi"];
                using(var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Clear();

                    HttpResponseMessage response = client.GetAsync(url +"/"+pokemon).Result;
                    return response;
                }

            }catch(Exception ex)
            {
                throw ex;
            }
        }



    }
}
