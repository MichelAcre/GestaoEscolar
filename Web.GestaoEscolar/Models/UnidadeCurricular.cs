using System.ComponentModel.DataAnnotations;

namespace GestaoEscolar;

public class UnidadeCurricular
{
    public Guid Id {get; set;}
    [Required(ErrorMessage = "O campo 'Nome' é obrigatório.")]
    [StringLength(100, ErrorMessage = "O campo 'Nome' deve ter entre 3 e 100 caractéres.")]
    [MinLength(3, ErrorMessage = "O campo 'Nome' deve ter entre 3 e 100 caractéres.")]
    
    public string? Nome {get;set;}
    [Required]
    [Display(Name = "Carga Horária")]
    [Range(1, 400, ErrorMessage = "A carga horária deve estar entre 1h e 400h.")]
    public int CargaHoraria {get;set;}
    [Required(ErrorMessage = "O campo 'Sigla' é obrigatório.")]
    [StringLength(10, ErrorMessage = "O campo 'Sigla' deve ter entre 2 e 10 caractéres.")]
    [MinLength(2, ErrorMessage = "O campo 'Sigla' deve ter entre 2 e 100 caractéres.")]
    public string Sigla {get;set;}
}
