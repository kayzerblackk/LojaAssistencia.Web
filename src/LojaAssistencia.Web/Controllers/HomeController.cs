using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LojaAssistencia.Web.Models;

namespace LojaAssistencia.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Home()
    {
        return View();
    }

    public IActionResult Produtos()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}