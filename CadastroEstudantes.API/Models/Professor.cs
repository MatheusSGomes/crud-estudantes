using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroEstudantes.API.Models;
public class Professor
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Titulacao { get; set; }

    // Relacionamento
    public Curso Curso { get; set; }
}