using Microsoft.AspNetCore.Mvc;

namespace PokemonTracker.API.Controller;

[Route("/")]
[ApiController]
public class HomeController : ControllerBase
{
    [HttpGet]
    public ActionResult Welcome()
    {
        return Ok("It's Time");
    }
}