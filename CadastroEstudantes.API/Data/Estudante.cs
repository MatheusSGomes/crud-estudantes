using System.ComponentModel.DataAnnotations;

namespace CadastroEstudantes.API.Data;

public class Estudante
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Turma { get; set; }
}