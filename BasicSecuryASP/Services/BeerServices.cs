using BasicSecuryASP.Models;
using System.Text.Json;

namespace BasicSecuryASP.Services
{
    public class BeerServices : IBeerService
    {
        readonly string path = "C:\\Users\\UTBFM-El02\\source\\repos\\BasicSecuryASP\\BasicSecuryASP\\beers.json";

        public async Task<List<Beer>> Get()
        {
            string content = await File.ReadAllTextAsync(path);
            var beers = JsonSerializer.Deserialize<List<Beer>>(content);
            return beers;

        }
    }
}
