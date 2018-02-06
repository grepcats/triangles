using Microsoft.AspNetCore.Mvc;
using Triangles.Models;

namespace Triangles.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Triangles()
    {
      return View();
    }

    [Route("/answer")]
    public ActionResult TriType()
    {
      TriangleType whatIsIt = new TriangleType();
      whatIsIt.Side1 = int.Parse(Request.Query["side1"]);
      whatIsIt.Side2 = int.Parse(Request.Query["side2"]);
      whatIsIt.Side3 = int.Parse(Request.Query["side3"]);

      return View("answer", whatIsIt);
    }
  }
}
