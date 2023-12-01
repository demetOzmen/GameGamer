using Bussiness.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : Controller
    {
        private IGameService _gameService;
        public GamesController(IGameService gameService)
        {
            _gameService = gameService;
        }

        public IActionResult Index()
        {
            var players = _gameService.GetList();
            return View();
        }

    }
}
