using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MicrowaveCommander.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProgramsDbSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Meal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeInMinutes = table.Column<int>(type: "int", nullable: false),
                    TimeInSeconds = table.Column<int>(type: "int", nullable: false),
                    Power = table.Column<int>(type: "int", nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcessingString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCustom = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramsDbSet", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProgramsDbSet",
                columns: new[] { "Id", "Instructions", "IsCustom", "Meal", "Name", "Power", "ProcessingString", "TimeInMinutes", "TimeInSeconds" },
                values: new object[,]
                {
                    { 1, "Observar o barulho de estouros do milho, caso houver um intervalo de mais de 10 segundos entre um estouro e outro, interrompa o aquecimento.", false, "Pipoca (de micro-ondas)", "Pipoca", 7, "p", 3, 183 },
                    { 2, "Cuidado com aquecimento de líquidos, o choque térmico aliado ao movimento do recipiente pode causar fervura imediata causando risco de queimaduras.", false, "Leite", "Leite", 5, "l", 5, 300 },
                    { 3, "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.", false, "Carne em pedaço ou fatias", "Carnes de boi", 4, "c", 14, 840 },
                    { 4, "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.", false, "Frango (qualquer corte)", "Frango", 7, "f", 8, 480 },
                    { 5, "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.", false, "Feijão congelado", "Feijão", 9, "j", 8, 480 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProgramsDbSet");
        }
    }
}
