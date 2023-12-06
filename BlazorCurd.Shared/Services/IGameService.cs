using BlazorCrud.Shared.Entities;

namespace BlazorCrud.Shared.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();
        Task<Game> GetGameById(int id);
        Task<Game> AddGame(Game game);

        Task<Game> UpdateGame(int id, Game game);
        Task<bool> DeleteGame(int id);
    }
}
