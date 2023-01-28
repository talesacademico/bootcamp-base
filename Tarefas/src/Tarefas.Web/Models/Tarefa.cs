using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Tarefas.Web.Models;

public class Tarefa
{
    public int Id { get; set; }

    [Required(ErrorMessage ="Por favor informe o Título")]
    [MinLength(3, ErrorMessage ="Título deve conter no mínimo 3 caracteres")]
    [DisplayName("Título")]    
    public string? Titulo { get; set; }    

    [Required(ErrorMessage ="Por favor informe a Descrição")]
    [MinLength(3, ErrorMessage ="Descrição deve conter no mínimo 3 caracteres")]
    [DisplayName("Descrição")]    
    public string? Descricao { get; set; }  

    [DisplayName("Concluída")]
    public bool Concluida { get; set; }
}