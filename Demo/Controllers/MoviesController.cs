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

        // Get: baseURL/Movies/GetMovie/{id} => 1. Route Data   -> Segment
        // Get: baseURL/Movies/GetMovie?id   => 2. Query string -> QueryParam
        public IActionResult/*ContentResult*/ GetMovie(int id, string name, Employee employee)
        {

            /// if (id == 0)
            ///     return new BadRequestResult();
            /// else if (id == 100)
            ///     return new NotFoundResult();
            ///
            /// ContentResult result = new ContentResult();
            /// 
            /// result.Content = $"<h1>Movie With Id: {id}, Name: {name}</h1>";
            /// 
            /// result.ContentType = "text/html";
            /// 
            /// //result.StatusCode = 404;
            /// 
            /// return result;
            /// 
            if (id == 0)
                return BadRequest();
            else if (id == 100)
                return NotFound();
            return Content($"<h1>Movie With Id: {id}, Name: {name}</h1>", "text/html");
        }

        //public IActionResult hamada()
        //{
        //    RedirectResult result = new RedirectResult(_configuration["Wazuf"] ?? string.Empty);
        //    RedirectResult redirect = new RedirectResult($"{_configuration["BaseURL"]}/Movies/GetMovie/10");
        //    RedirectToActionResult redirectToActionResult = new RedirectToActionResult(nameof(GetMovie), "Movies", new { id = 10 });

        //                return result;
        //}

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