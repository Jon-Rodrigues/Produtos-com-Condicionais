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
            "R$5","R$30","R$5 milhões","R$20","R$15"
        };
    
        return View();
    }
}