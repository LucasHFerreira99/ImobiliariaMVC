using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ImobiliariaMVC.Migrations
{
    /// <inheritdoc />
    public partial class CriarBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Locadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cpf = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Identidade = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Endereco = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Atividade = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locadores", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Locatarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cpf = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Identidade = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Atividade = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locatarios", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Imoveis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Endereco = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Valor = table.Column<double>(type: "double", nullable: false),
                    Alugado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DonoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imoveis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imoveis_Locadores_DonoID",
                        column: x => x.DonoID,
                        principalTable: "Locadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Alugueis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LocatarioId = table.Column<int>(type: "int", nullable: false),
                    ImovelId = table.Column<int>(type: "int", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataSaida = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alugueis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alugueis_Imoveis_ImovelId",
                        column: x => x.ImovelId,
                        principalTable: "Imoveis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alugueis_Locatarios_LocatarioId",
                        column: x => x.LocatarioId,
                        principalTable: "Locatarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Locadores",
                columns: new[] { "Id", "Atividade", "Cpf", "Endereco", "Identidade", "Nome", "Telefone" },
                values: new object[,]
                {
                    { 1, "Comerciante", "123.345.231-12", "Rua Japão, 312", "MG12312312", "Joao Carlos", "38313555" },
                    { 2, "Padeiro", "654.655.211-12", "Rua Adolfo Pierucetii, 655", "MG8923712", "Marcos Castro", "988745454" }
                });

            migrationBuilder.InsertData(
                table: "Locatarios",
                columns: new[] { "Id", "Atividade", "Cpf", "Identidade", "Nome", "Telefone" },
                values: new object[,]
                {
                    { 1, "Mestre de Obra", "654.233.211-12", "MG4444442", "Juca Tadeu", "988774455" },
                    { 2, "Confuso", "122.233.211-12", "MG4324442", "Confuso Sobrinho", "966335544" },
                    { 3, "Influencer", "111.233.211-12", "MG5555552", "Chico Moedas", "988552233" }
                });

            migrationBuilder.InsertData(
                table: "Imoveis",
                columns: new[] { "Id", "Alugado", "DonoID", "Endereco", "Valor" },
                values: new object[,]
                {
                    { 1, false, 2, "Rua da Esperança, 777", 770.0 },
                    { 2, false, 2, "Rua das Palmeiras", 2000.0 },
                    { 3, false, 1, "Rua das Jacarandas", 1500.0 },
                    { 4, false, 1, "Rua dos Ipes, 249", 850.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alugueis_ImovelId",
                table: "Alugueis",
                column: "ImovelId");

            migrationBuilder.CreateIndex(
                name: "IX_Alugueis_LocatarioId",
                table: "Alugueis",
                column: "LocatarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Imoveis_DonoID",
                table: "Imoveis",
                column: "DonoID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alugueis");

            migrationBuilder.DropTable(
                name: "Imoveis");

            migrationBuilder.DropTable(
                name: "Locatarios");

            migrationBuilder.DropTable(
                name: "Locadores");
        }
    }
}
