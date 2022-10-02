using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "especialidade",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    criado = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    editado = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    situacao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_especialidade", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medico",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    crm = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    estado_crm = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    criado = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    editado = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    situacao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medico", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "unidade_saude",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cnpj = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    endereco = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numero = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telefone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    criado = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    editado = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    situacao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unidade_saude", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "busca_especialidade",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_especialidade = table.Column<int>(type: "int", nullable: false),
                    descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Especialidadeid = table.Column<int>(type: "int", nullable: false),
                    criado = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    editado = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    situacao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_busca_especialidade", x => x.id);
                    table.ForeignKey(
                        name: "FK_busca_especialidade_especialidade_Especialidadeid",
                        column: x => x.Especialidadeid,
                        principalTable: "especialidade",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "plantao",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_unidade = table.Column<int>(type: "int", nullable: false),
                    id_medico = table.Column<int>(type: "int", nullable: false),
                    id_especialidade = table.Column<int>(type: "int", nullable: false),
                    horarioinicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    horariofim = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    dia_semana = table.Column<int>(type: "int", nullable: false),
                    UnidadeSaudesid = table.Column<int>(type: "int", nullable: false),
                    Medicosid = table.Column<int>(type: "int", nullable: false),
                    Especialidadesid = table.Column<int>(type: "int", nullable: false),
                    criado = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    editado = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    situacao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plantao", x => x.id);
                    table.ForeignKey(
                        name: "FK_plantao_especialidade_Especialidadesid",
                        column: x => x.Especialidadesid,
                        principalTable: "especialidade",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_plantao_medico_Medicosid",
                        column: x => x.Medicosid,
                        principalTable: "medico",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_plantao_unidade_saude_UnidadeSaudesid",
                        column: x => x.UnidadeSaudesid,
                        principalTable: "unidade_saude",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_busca_especialidade_Especialidadeid",
                table: "busca_especialidade",
                column: "Especialidadeid");

            migrationBuilder.CreateIndex(
                name: "IX_plantao_Especialidadesid",
                table: "plantao",
                column: "Especialidadesid");

            migrationBuilder.CreateIndex(
                name: "IX_plantao_Medicosid",
                table: "plantao",
                column: "Medicosid");

            migrationBuilder.CreateIndex(
                name: "IX_plantao_UnidadeSaudesid",
                table: "plantao",
                column: "UnidadeSaudesid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "busca_especialidade");

            migrationBuilder.DropTable(
                name: "plantao");

            migrationBuilder.DropTable(
                name: "especialidade");

            migrationBuilder.DropTable(
                name: "medico");

            migrationBuilder.DropTable(
                name: "unidade_saude");
        }
    }
}
