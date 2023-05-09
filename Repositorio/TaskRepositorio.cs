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

    public TaskModel ListarPorId(int id)
    {
        return _bancoContext.Tasks.FirstOrDefault(x => x.Id == id);
    }
 
    public TaskModel Adicionar(TaskModel task)
    {
        //gravar no banco
        _bancoContext.Tasks.Add(task);

        _bancoContext.SaveChanges();

        return task;
    }

    public TaskModel Atualizar(TaskModel task)
    {
        TaskModel taskDB = ListarPorId(task.Id);

        if(taskDB == null)
        {
            throw new Exception("Erro ao atualizar o banco");
        }

        taskDB.Description = task.Description;

        _bancoContext.Tasks.Update(taskDB);

        _bancoContext.SaveChanges();

        return taskDB;
    }
}
