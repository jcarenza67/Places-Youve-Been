using ProjectName.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassName.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult MethodName()
    {
      return View();
    }
  }
}