using Microsoft.AspNetCore.Mvc;
using WebApiRecipe.Services.Services.Interfaces;

namespace WebApiRecipes.Controllers
{
    public class UserController : Controller
    {
        private readonly  IUserService _userService;
        public UserController (IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }   
    }
}
