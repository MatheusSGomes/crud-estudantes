using System;
using System.Data;
using Microsoft.EntityFrameworkCore;
using CadastroEstudantes.API.Models;

namespace CadastroEstudantes.API.Data;

public class EstudanteContext : DbContext
{
    public EstudanteContext(DbContextOptions<EstudanteContext> options) : base (options) { }

    public DbSet<Estudante> Estudantes { get; set; }
}