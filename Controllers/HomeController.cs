using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Princess Angela", StudentId = "21-1974", StudentAge = "25" },
            new StudentInfoModel { Name = "Villamor Vergara", StudentId = "06-1975", StudentAge = "24" },
            new StudentInfoModel { Name = "Zaina Ann", StudentId = "02-2016", StudentAge = "21" }
        };

        return View(studentInfoArray);
    }
}
