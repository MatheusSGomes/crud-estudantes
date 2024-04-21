using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CadastroEstudantes.API.Data;
using CadastroEstudantes.API.Models;

namespace CadastroEstudantes.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EstudantesController : ControllerBase
{
    private readonly EscolaContext _context;

    public EstudantesController(EscolaContext context)
    {
        _context = context;
    }


    /// <summary>
    /// Rota que lista todos os estudantes
    /// </summary>
    /// <returns></returns>
    // GET: api/Estudantes
    [HttpGet]
    public string GetEstudantes()
    {
        return "Retorna todos os Estudantes";
    }

    [HttpGet("{id}")]
    public string GetEstudante(int id)
    {
        return "Retorna um Estudante";
    }

    [HttpPut("{id}")]
    public string PutEstudante(int id, Estudante estudante)
    {
        return "Atualiza um Estudante";
    }

    [HttpPost]
    public string PostEstudante(Estudante estudante)
    {
        return "Adiciona um Estudante";
    }

    [HttpDelete]
    public string DeleteEstudante(int id)
    {
        return "Apaga um Estudante";
    }

    private string EstudanteExists(int id) // bool
    {
        return "valida existencia estudante";
    }
}
