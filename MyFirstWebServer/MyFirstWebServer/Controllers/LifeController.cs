using Microsoft.AspNetCore.Mvc;
using MyFirstWebServer.Models.ViewModels;

namespace MyFirstWebServer.Controllers;

public class LifeController : Controller
{
    // GET : life / borsh
    public IActionResult Borsch()
    {
        SeoPageViewModel vmSeo = new SeoPageViewModel();
        vmSeo.Title = "Як варити борщ";
        vmSeo.Description = "Мій рецепт";

        ViewBag.seo = vmSeo;
        
        // Збір та перевіка данниіх
        List<string> products = new List<string>();
        
        products.Add("Буряк");
        products.Add("Картопля");
        products.Add("М'ясо");
        products.Add("Самогонка");

        string recipe = " Сварити борщ на налити гранчак ";

        // Склали данні у об'екти обміну 
        ViewBag.products = products;
        ViewData["recipe"] = recipe;
        
        return View();
    }
}