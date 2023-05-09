using TuDu.Models;

namespace TuDu.Repositorio;

public interface ITaskRepositorio
{
    TaskModel ListarPorId(int id);

    List<TaskModel> BuscarTodos();

    TaskModel Adicionar(TaskModel task);

    TaskModel Atualizar(TaskModel task);

    bool Excluir(int id);

    bool Check(TaskModel task);
}
