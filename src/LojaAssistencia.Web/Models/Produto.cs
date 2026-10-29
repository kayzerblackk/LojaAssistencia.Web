using System.Diagnostics.CodeAnalysis;

namespace LojaAssistencia.Web.Models;
public class Produto
{
    public int Id { get; set; }
    public string Nome { get; init; }
    public string Descricao { get; set; } = string.Empty;
    public decimal Preco { get; set; }

    public Produto(int id, string nome, string descricao, decimal preco)
    {
        Id = id;
        Nome = nome;
        Descricao = descricao;
        Preco = preco;
    }

}