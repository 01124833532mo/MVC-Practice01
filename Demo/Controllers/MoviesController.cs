using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers 
{
    public class MoviesController : Controller
    {
        // action : public non static object member methode inside the controller 
        //baseurl/movies/getmovie/{id}
        [HttpGet]
        public string Index()
        {
            return $"All Movies";
        }
        [HttpGet]

        public string GetMovie(int id)
        {
            return $"movie with id : {id}";
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