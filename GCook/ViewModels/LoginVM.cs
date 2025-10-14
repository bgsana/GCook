using System.ComponentModel.DataAnnotations;

namespace GCook.ViewModels;
public class LoginVM
{
    [Display(Name = "Email ou nome de usuário", Prompt = "Informe seu email ou nome de usuário")]
    [Required(ErrorMessage = "O Email ou nome de usuário é obrigatório")]
    public string Email { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Senha de Acesso", Prompt = "**********")]
    [Required(ErrorMessage = "A senha é obrigatória")]
    public string Senha { get; set; }

    [Display(Name = "Manter conectado?")]
    public bool Lembrar { get; set; } = false;

    public string UrlRetorno { get; set; }
}
