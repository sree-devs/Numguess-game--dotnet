using Microsoft.AspNetCore.Mvc;
using NumberGuessingGameWeb.Services;
using System;

namespace NumberGuessingGameWeb.Controllers
{
    public class GameController : Controller
    {
        private readonly GameService _gameService;

        public GameController(GameService gameService)
        {
            _gameService = gameService;
        }

        // GET: /Game/
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Game/Guess
        [HttpPost]
        public IActionResult Guess(int userGuess)
        {
            string message = _gameService.Guess(userGuess);
            ViewBag.Message = message; // Store the message in ViewBag to display it on the view
            return View("Index");
        }

        // POST: /Game/Reset
        [HttpPost]
        public IActionResult Reset()
        {
            _gameService.ResetGame();
            return View("Index");
        }
    }
}
