using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using LojaAssistencia.Web.Models;

namespace LojaAssistencia.Web.Controllers;

public class ProdutosController : Controller
{
    private List<Produto> ObterProdutos()
    {
        List<Produto> produtos = new List<Produto>();
        
        for (int i = 1; i <= 10; i++)
        {
            Produto produtoNovo = new Produto(i, $"Produto {i}", $"Descrição do produto {i}", 49.99m + i);
            produtos.Add(produtoNovo);
        }

        foreach (Produto produto in produtos)
        {
            Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Descrição: {produto.Descricao}, Preço: {produto.Preco}");
        }

        return produtos;
    }
    
    public IActionResult Index()
    {
        List<Produto> produtos = ObterProdutos();

        return View(produtos);
    }

    /*

    public IActionResult Detalhes(int id)
    {
        // Lógica para obter os detalhes do produto com base no ID
        // Por exemplo, você pode buscar o produto em um banco de dados ou serviço

        // Exemplo de produto fictício
        var produto = new Produto
        {
            Id = id,
            Nome = "Produto Exemplo",
            Descricao = "Descrição do produto exemplo.",
            Preco = 99.99m
        };

        return View(produto);
    }

    */
}