using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc; 

namespace DojoSurvey.Controllers
{
  public class DojoSurveyController : Controller
  {
    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
      return View("Index");
    }

    [HttpPost]
    [Route("/result")]
    public IActionResult Result(string name, string location, string language, string comment)
    {
      ViewBag.name = name; 
      ViewBag.location = location; 
      ViewBag.language = language;
      ViewBag.comment = comment; 
      return View("Result");
    }
  }
}