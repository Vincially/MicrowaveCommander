using Microsoft.EntityFrameworkCore;
using MicrowaveCommander.Domain.Entities;

namespace MicrowaveCommander.Infrastructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Programs> ProgramsDbSet { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Programs>().HasData(
            new Programs
            {
                Id = 1,
                Name = "Pipoca",
                Meal = "Pipoca (de micro-ondas)",
                TimeInMinutes = 3,
                TimeInSeconds = 183,
                Power = 7,
                Instructions = "Observar o barulho de estouros do milho, caso houver um intervalo de mais de 10 segundos entre um estouro e outro, interrompa o aquecimento.",
                ProcessingString = "p",
                IsCustom = false
            },
            new Programs
            {
                Id = 2,
                Name = "Leite",
                Meal = "Leite",
                TimeInMinutes = 5,
                TimeInSeconds = 300,
                Power = 5,
                Instructions = "Cuidado com aquecimento de líquidos, o choque térmico aliado ao movimento do recipiente pode causar fervura imediata causando risco de queimaduras.",
                ProcessingString = "l",
                IsCustom = false
                
            },
            new Programs
            {
                Id = 3,
                Name = "Carnes de boi",
                Meal = "Carne em pedaço ou fatias",
                TimeInMinutes = 14,
                TimeInSeconds = 840,
                Power = 4,
                Instructions = "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.",
                ProcessingString = "c",
                IsCustom = false
            },
            new Programs
            {
                Id = 4,
                Name = "Frango",
                Meal = "Frango (qualquer corte)",
                TimeInMinutes = 8,
                TimeInSeconds = 480,
                Power = 7,
                Instructions = "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.",
                ProcessingString = "f",
                IsCustom = false
            },
            new Programs
            {
                Id = 5,
                Name = "Feijão",
                Meal = "Feijão congelado",
                TimeInMinutes = 8,
                TimeInSeconds = 480,
                Power = 9,
                Instructions = "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.",
                ProcessingString = "j",
                IsCustom = false
            }
        );
    }

    
}