using BlazorCrud.Shared.Data;
using BlazorCrud.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BlazorCrud.Shared.Services
{
    public class GameService(DataContext context) : IGameService
    {
        public async Task<Game> AddGame(Game game)
        {
            context.Games.Add(game);
            await context.SaveChangesAsync();
            return game;
        }

        public async Task<bool> DeleteGame(int id)
        {
            var gameToDelete = await GetGameById(id);

            if (gameToDelete != null)
            {
                context.Remove(gameToDelete);
                await context.SaveChangesAsync();
                return true;
            }
            
            return false;
        }

        public async Task<List<Game>> GetAllGames()
        {
            return await context.Games.ToListAsync();
        }

        public async Task<Game> GetGameById(int id)
        {
            return await context.Games.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Game> UpdateGame(int id, Game game)
        {
            var gameToUpdate = await GetGameById(id);
            if (gameToUpdate != null)
            {
                gameToUpdate.Name = game.Name;
                gameToUpdate.Description = game.Description;
                //context.Update(gameToUpdate);
                await context.SaveChangesAsync();
                return gameToUpdate;
            }
            throw new Exception("Game not found");


        }
    }
}
