using System.ComponentModel.DataAnnotations;

namespace TuDu.Models;

public class TaskModel
{
    public int Id { get; set; }

    [Required(ErrorMessage ="A descrição é obrigatoria")]
    public string Description { get; set; }
        
    public bool IsCompleted { get; set; } = false;
}
