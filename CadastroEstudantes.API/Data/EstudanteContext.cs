using Microsoft.EntityFrameworkCore;

namespace CadastroEstudantes.API.Data;

public class EstudanteContext : DbContext
{
    public EstudanteContext(DbContextOptions<EstudanteContext> options)
    : base (options)
    { }

    public DbSet<Estudante> Estudantes { get; set; }
}