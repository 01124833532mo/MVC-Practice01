using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
	public class AccountsController : Controller
	{
		public IActionResult Singin()
		{
			return View();
		}
		public IActionResult Singup()
		{
			return View();
		}
	}
}
