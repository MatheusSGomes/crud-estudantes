using Xunit;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Mvc;
using CadastroEstudantes.API.Data;
using CadastroEstudantes.API.Models;
using CadastroEstudantes.API.Controllers;

namespace CadastroEstudantes.Tests;

public class GetEstudantes
{

    private DbContextOptions<EstudanteContext> CriarOpcoesDoBancoDeDados(string nomeBanco)
    {
        return new DbContextOptionsBuilder<EstudanteContext>()
            .UseInMemoryDatabase(nomeBanco)
            .Options;
    }

    [Fact]
    public async Task GetEstudantes_DeveRetornarTodosOsEstudantes()
    {
        // Arrange
        var options = CriarOpcoesDoBancoDeDados("GetEstudantes");

        using (var context = new EstudanteContext(options))
        {
            context.Estudantes.AddRange(new List<Estudante>
            {
                new Estudante { Id = 1, Nome = "Estudante 1", Email = "estudante1@email.com", Ativo = true },
                new Estudante { Id = 2, Nome = "Estudante 2", Email = "estudante2@email.com", Ativo = true },
                new Estudante { Id = 3, Nome = "Estudante 3", Email = "estudante3@email.com", Ativo = true },
            });
            context.SaveChanges();
        }

        using (var context = new EstudanteContext(options))
        {
            var controller = new EstudantesController(context);

            // Act
            var result = await controller.GetEstudantes();

            // Assert
            var okResult = Assert.IsType<ActionResult<IEnumerable<Estudante>>>(result);
            var estudantes = Assert.IsAssignableFrom<IEnumerable<Estudante>>(okResult.Value);
            Assert.Equal(3, estudantes.Count());
        }
    }
}