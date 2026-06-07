using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProdutosComCondicionais.Models;

namespace ProdutosComCondicionais.Controllers;

public class ProdutoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Produtos = new List<string>
        {
            "Cinto de utilidade","Laço da verdade","Lançador de teia","Anel lanterna verde","Kriptonita"
        };

        ViewBag.ProdutosValor = new List<double>
        {
            5,30,5000000,20,15
        };
    
        return View();
    }
}