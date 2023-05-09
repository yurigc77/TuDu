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

    public IActionResult EditarTask(int id)
    {
        TaskModel task = _taskRepositorio.ListarPorId(id);
        return View(task);
    }

    public IActionResult ExcluirTask(int id)
    {
        TaskModel task = _taskRepositorio.ListarPorId(id);
        return View(task);
    }

    public IActionResult Excluir(int id)
    {
        _taskRepositorio.Excluir(id);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult CriarTask(TaskModel task)
    {
        if (ModelState.IsValid)
        {
            _taskRepositorio.Adicionar(task);
            return RedirectToAction("Index");
        }

        return View(task);

    }

    [HttpPost]
    public IActionResult EditarTask(TaskModel task)
    {
        if (ModelState.IsValid)
        {
            _taskRepositorio.Atualizar(task);
            return RedirectToAction("Index");
        }

        return View(task);
    }
}
