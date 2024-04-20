using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroEstudantes.API.Models;
public class Curso
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DataType DataInicio { get; set; }

    public int ProfessorId { get; set; } // Chave estrangeira

    public Professor Professor { get; set; } // Relacionamento

    public List<EstudanteCurso> EstudanteCursos { get; set; }
}