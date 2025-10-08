using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GCook.Models;
public class Receita
{
    [Key]
    public int Id { get; set; }

    public int CategoriaId { get; set; }

    [StringLength(50)]
    [Required(ErrorMessage = "O nome é obrigatório")]
    public string Nome { get; set; }

    [StringLength(1000)]
    public string Descricao { get; set; }

    [StringLength(30)]
    public string TempoPreparo { get; set; }

    public int Rendimento { get; set; }

    public Dificuldade Dificuldade { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }

    [StringLength(8000)]
    public string Preparo { get; set; }
}

