using System.ComponentModel.DataAnnotations;
using CadastroEstudantes.API.Models;

namespace CadastroEstudantes.API.Data;

public class Estudante
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Turma { get; set; }

    public List<EstudanteCurso> EstudantesCursos { get; set; }
}