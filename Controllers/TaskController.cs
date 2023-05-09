using Microsoft.AspNetCore.Mvc;
using TuDu.Models;
using TuDu.Repositorio;

namespace TuDu.Controllers;

public class TaskController : Controller
{
    private readonly ITaskRepositorio _taskRepositorio;

    public TaskController(ITaskRepositorio taskRepositorio)
    {
        _taskRepositorio = taskRepositorio;
    }

    public IActionResult Index()
    {
        var tasks = _taskRepositorio.BuscarTodos();
        return View(tasks);
    }

    public IActionResult CriarTask()
    {
        return View();
    }

    public IActionResult EditarTask()
    {
        return View();
    }

    public IActionResult ExcluirTask()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CriarTask(TaskModel task)
    {
        _taskRepositorio.Adicionar(task);
        return RedirectToAction("Index");
    }
}
