using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers 
{
    public class MoviesController : Controller
    {
        private readonly IConfiguration _configuration;

        // action : public non static object member methode inside the controller 
        //baseurl/movies/getmovie/{id}

        public MoviesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public string Index()
        {
            return $"All Movies";
        }
        [HttpGet]

        public IActionResult GetMovie(int id)
        {
            if (id == 0)
            {
                //return bad request
                return BadRequest();
            }
            if (id == 100)
            {
                // return notfindresult()
                return NotFound();
            }
            //ContentResult result = new ContentResult();
            //result.Content = $"<h1> movie with id :{id} </h1>";
            //result.ContentType = "text/html";
            //result.StatusCode = 200;


            return Content($"<h1> movie with id :{id} </h1>", "text/html");

        }

        public IActionResult hamada()
        {
            RedirectResult result = new RedirectResult(_configuration["Wazuf"] ?? string.Empty);
            RedirectResult redirect = new RedirectResult($"{_configuration["BaseURL"]}/Movies/GetMovie/10");
            RedirectToActionResult redirectToActionResult = new RedirectToActionResult(nameof(GetMovie), "Movies", new { id = 10 });
            
                        return result;
        }

        [HttpGet]
        //[AcceptVerbs("Get","Post")]
        public ViewResult CreateMovie()
        {
            return new ViewResult();
        }

        [HttpPost]
        public OkResult CreateMovie(Movie model)
        {
            return new OkResult();
        }


    }
}