using Microsoft.AspNetCore.Mvc;
using unitoneproject.Models; // Ensure this is present

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Calculate()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Calculate(MathModel model)
    {
        if (ModelState.IsValid)
        {
            model.Result = model.Number1 + model.Number2;
        }
        return View(model);
    }
}
