using BlazorCrud.Shared.Entities;
using BlazorCrud.Shared.Services;
using System.Net.Http.Json;

namespace BlazorCurd.Shared.Services
{
    public class ClientGameService(HttpClient httpClient) : IGameService
    {
        public async Task<Game> AddGame(Game game)
        {
            var result = await httpClient.PostAsJsonAsync("/api/game", game);
            return await result.Content.ReadFromJsonAsync<Game>();
        }

        public async Task<bool> DeleteGame(int id)
        {
            var result = await httpClient.DeleteAsync($"/api/game/{id}");
            return await result.Content.ReadFromJsonAsync<bool>();
        }

        public Task<List<Game>> GetAllGames()
        {
            throw new NotImplementedException();
        }

        public async Task<Game> GetGameById(int id)
        {
            var result = await httpClient.GetFromJsonAsync<Game>($"/api/game/{id}");
            return result;
        }

        public async Task<Game> UpdateGame(int id, Game game)
        {
            var result = await httpClient.PutAsJsonAsync($"/api/game/{id}", game);
            return await result.Content.ReadFromJsonAsync<Game>();
        }
    }
}
