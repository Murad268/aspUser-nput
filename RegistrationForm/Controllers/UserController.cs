using Microsoft.AspNetCore.Mvc;
using RegistrationForm.Repositories;

namespace RegistrationForm.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View(UserRepository.GetUsers());
        }
    }
}
