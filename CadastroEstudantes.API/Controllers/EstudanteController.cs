using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Estudante.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EstudanteController : ControllerBase
{
    /// <summary>
    /// Rota que lista todos os estudantes
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public string Get()
    {
        return "Olá mundo!";
    }
}
