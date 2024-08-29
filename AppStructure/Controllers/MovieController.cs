using Microsoft.AspNetCore.Mvc;

namespace AppStructure.Controllers
{
    public class MovieController:Controller
    {
        public IActionResult  GetMovie(int id,string name, Employee employee)
        {
            //ContentResult result = new ContentResult();
            //result.Content = $"Movie with id{id}";
            //result.ContentType= "object/pdf" ;
            //result.StatusCode = 200 ;
            return Content($"Movie with id{id}", "object/pdf");
        }
        public IActionResult Index()
        {
            //RedirectResult redirect=new RedirectResult("https://localhost:44366/Movie/GetMovie");
            return Redirect ("https://localhost:44366/Movie/GetMovie");
            //return Redirect("{BaseUrl}/Movie/GetMovie/10");
            //return RedirectToAction(nameof(GetMovie), new { id = 10 });
            //return RedirectToRoute("default", new { controller = "product", action = "GetProduct" });



        }
        public ViewResult Hamada()
        {
            return View();
        }
    }
}
