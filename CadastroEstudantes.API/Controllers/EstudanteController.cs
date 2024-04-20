using Microsoft.AspNetCore.Mvc;

namespace Estudante.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EstudanteController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Olá mundo!";
    }
}
