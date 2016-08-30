﻿using Microsoft.AspNetCore.Mvc;
using BitFighters.Web.Services;

namespace BitFighters.Web.Controllers
{
    public class HomeController : Controller
    {
        readonly IGameTypeService _gameTypeService;

        public HomeController(IGameTypeService gameTypeService)
        {
            _gameTypeService = gameTypeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Games()
        {
            ViewData["Message"] = "This is games.";

            return View();
        }

        public IActionResult JoinGame()
        {
            ViewData["Message"] = "Select game to join.";

            return View();
        }

        public IActionResult CreateGame()
        {
            ViewData["Message"] = "Create new game.";

            return View();
        }

        public IActionResult MyGames()
        {
            ViewData["Message"] = "My games.";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
