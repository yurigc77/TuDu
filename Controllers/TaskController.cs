using Microsoft.AspNetCore.Mvc;

namespace TuDu.Controllers;

public class TaskController : Controller
{
    public IActionResult Index()
    {
        return View();
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

}
