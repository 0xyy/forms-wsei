using Microsoft.AspNetCore.Mvc;
using Forms.Models;

public class UserProfileController : Controller
{
    [HttpGet]
    public IActionResult Form()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Form(UserProfile userProfile)
    {
        if (ModelState.IsValid)
        {
            return View("Result", userProfile);
        }
        return View();
    }

    public IActionResult Result(UserProfile userProfile)
    {
        return View(userProfile);
    }
}
