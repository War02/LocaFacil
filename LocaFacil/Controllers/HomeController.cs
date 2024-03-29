﻿using LocaFacil.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LocaFacil.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Ajuda()
        {
            return View();
        }

        public IActionResult VerDetalhes()
        {
            return View();
        }

        public IActionResult VerDetalhesMobi()
        {
            return View();
        }

        public IActionResult VerDetalhesHb()
        {
            return View();
        }

        public IActionResult VerDetalhesRene()
        {
            return View();
        }

        public IActionResult VerDetalhesPejo()
        {
            return View();
        }

        public IActionResult VerDetalhesGol()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}