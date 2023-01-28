using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Tarefas.Web.Models;

public class TarefaViewModel
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Por favor informe o título!")]
    [DisplayName("Título")]
    public string? Titulo { get; set; }        
    
    [Required(ErrorMessage = "Por favor informe uma descrição!")]
    [DisplayName("Descrição")]    
    public string? Descricao { get; set; }  

    [DisplayName("Concluída")]
    public bool Concluida { get; set; }
}