using System.Text.Json;
using BlazonDex.Models;

namespace BlazonDex.Util
{
    public class PokeClient
    {
        public HttpClient Client { get; set; }
        public PokeClient(HttpClient client)
        {
            this.Client = client;
        }
        public async Task<Pokemon> GetPokemon(string id)
        {
            var response = await Client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}");
            var content=await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Pokemon>(content);
        }
    }
}