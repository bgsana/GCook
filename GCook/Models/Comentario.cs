using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GCook.Models;

[Table("Comentario")]

public class Comentario
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "A receita é obrigatória")]
    public int ReceitaId { get; set; }
    [ForeignKey("ReceitaId")]
    [Display(Name = "Receita")]
    public Receita Receita { get; set; }

    [Required(ErrorMessage = "O usuário é obrigatório")]
    public string UsarioId { get; set; }
    [ForeignKey("UsarioId")]
    [Display(Name = "Usuário")]
    public Usuario Usuario { get; set; }

    [Display(Name = "Data do comentário")]
    [Required(ErrorMessage ="A data do comentário é obrigatória")]
    public DateTime DataComentario { get; set; }

    [StringLength(300)]
    [Display(Name ="Texto do comentário")]
    [Required(ErrorMessage ="O texto é obrigatório")]
    public string TextoComentario { get; set; }
}
