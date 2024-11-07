using Microsoft.AspNetCore.Mvc;

namespace UdemyDiaryApp.Controllers;

public class DiaryEntriesController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}