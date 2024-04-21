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
    public async Task<ActionResult<Estudante>> GetEstudante(int id)
    {
        var estudante = await _context.Estudantes.FindAsync(id);

        if (estudante == null) {
            // throw new KeyNotFoundException("Estudante não encontrado");
            return NotFound();
        }

        return estudante;
    }

    [HttpPost]
    public async Task<ActionResult<Estudante>> PostEstudante(Estudante estudante)
    {
        _context.Estudantes.Add(estudante);

        await _context.SaveChangesAsync();

        return CreatedAtAction("GetEstudante", new { id = estudante.Id }, estudante);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutEstudante(int id, Estudante estudante)
    {
        if (id != estudante.Id) {
            return BadRequest();
        }

        _context.Entry(estudante).State = EntityState.Modified;

        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteEstudante(int id)
    {
        var estudante = await _context.Estudantes.FindAsync(id);

        if (estudante == null) {
            return NotFound();
        }

        _context.Estudantes.Remove(estudante);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
