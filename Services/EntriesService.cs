using ApiPrueba.Model;
using System.Text.Json;

namespace ApiPrueba.Services
{
    public class EntriesService
    {
        HttpClient _httpClient;

        public EntriesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<EntriesResult> GetEntries()
        {

                var response = await _httpClient.GetAsync("entries");

                var content = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<EntriesResult>(content);

                return result;
           
        }

    }
 
}
