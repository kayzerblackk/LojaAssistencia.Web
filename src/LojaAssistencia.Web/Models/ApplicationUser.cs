using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace LojaAssistencia.Web.Models;

public class ApplicationUser : IdentityUser
{
    [Required]
    public string NomeCompleto { get; set; }
    public string? Endereco { get; set; }
    public string? CPF {get; set; }
}