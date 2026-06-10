using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProdutosComCondicionais.Models;

namespace ProdutosComCondicionais.Controllers;

public class ProdutoController : Controller
{
    public IActionResult Index()
    {
        var produtos = new List<string>
            {
                "Cinto de utilidade","Laço da verdade","Lançador de teia","Anel lanterna verde","Kriptonita"
            };

            var precos = new List<double>
            {
                5,30,500,20,150
            };

            ViewBag.Produtos = produtos;
            ViewBag.Precos  = precos;

            return View();
    }
}