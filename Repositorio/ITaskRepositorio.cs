using TuDu.Models;

namespace TuDu.Repositorio;

public interface ITaskRepositorio
{
    List<TaskModel> BuscarTodos();

    TaskModel Adicionar(TaskModel task);

}
