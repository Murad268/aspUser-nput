using Microsoft.AspNetCore.Mvc;
using RegistrationForm.Models;
using RegistrationForm.Repositories;

namespace RegistrationForm.Controllers
{
    public class RegistrationController : Controller
    {
    
        public IActionResult Index()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Index(User user)
        {

            if (ModelState.IsValid)
            {
                UserRepository.AddUser(user);
                return View("Reply", user);

            }

            return View();

        }

        public IActionResult Reply()
        {
            return View();
        }
    }
}
