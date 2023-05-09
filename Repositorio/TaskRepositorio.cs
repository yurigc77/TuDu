using TuDu.Data;
using TuDu.Models;

namespace TuDu.Repositorio;


public class TaskRepositorio : ITaskRepositorio
{

    private readonly BancoContext _bancoContext;

    public TaskRepositorio(BancoContext bancoContext)
    {
        _bancoContext = bancoContext;
    }

    public List<TaskModel> BuscarTodos()
    {
        return _bancoContext.Tasks.ToList();
    }
 
    public TaskModel Adicionar(TaskModel task)
    {
        //gravar no banco
        _bancoContext.Tasks.Add(task);

        _bancoContext.SaveChanges();

        return task;
    }

}
