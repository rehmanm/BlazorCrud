using BlazorCrud.Shared.Entities;
using BlazorCrud.Shared.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController(IGameService gameService) : ControllerBase
    {

        [HttpPost]
        public async Task<ActionResult<Game>> AddGame(Game game)
        {
            var addGame = await gameService.AddGame(game);
            return Ok(addGame);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Game>> GetGameById(int id)
        {
            var game = await gameService.GetGameById(id);
            return Ok(game);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Game>> UpdateGameById(int id, Game game)
        {
            var result = await gameService.UpdateGame(id, game);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteGameById(int id)
        {
            var result = await gameService.DeleteGame(id);
            return Ok(result);
        }
    }
}
