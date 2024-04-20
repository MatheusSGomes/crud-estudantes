using Microsoft.EntityFrameworkCore;
using CadastroEstudantes.API.Models;

namespace CadastroEstudantes.API.Data;

public class EscolaContext : DbContext
{
    public EscolaContext(DbContextOptions<EscolaContext> options) : base (options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EstudanteCurso>()
            .HasKey(ac => new { ac.EstudanteId, ac.CursoId });
    }

    public DbSet<Estudante> Estudantes { get; set; }
    public DbSet<Professor> Professores { get; set; }
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<EstudanteCurso> EstudantesCursos { get; set; }
}