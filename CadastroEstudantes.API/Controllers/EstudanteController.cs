using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CadastroEstudantes.API.Data;
using CadastroEstudantes.API.Models;
using Microsoft.EntityFrameworkCore;

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
    public async Task<ActionResult<IEnumerable<Estudante>>> GetEstudantes()
    {
        return await _context.Estudantes.ToListAsync();
    }

    [HttpGet("{id}")]
    public Estudante GetEstudante(int id)
    {
        var estudante = _context.Estudantes.Find(id);
        if (estudante == null) throw new KeyNotFoundException("Estudante não encontrado");
        return estudante;
    }

    [HttpPost]
    public string PostEstudante(Estudante estudante)
    {
        Console.Write(estudante);

        Console.WriteLine(estudante);
        return "Adiciona um Estudante:" + estudante.Ativo;
    }

    [HttpPut("{id}")]
    public string PutEstudante(int id, Estudante estudante)
    {
        return "Atualiza um Estudante";
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
