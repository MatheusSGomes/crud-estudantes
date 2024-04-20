using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroEstudantes.API.Models;

public class EstudanteCurso
{
    public int EstudanteId { get; set; }
    public int CursoId { get; set; }

    public Estudante Estudante { get; set; }
    public Curso Curso { get; set; }
}