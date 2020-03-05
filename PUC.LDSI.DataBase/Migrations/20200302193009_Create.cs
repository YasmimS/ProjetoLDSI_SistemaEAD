using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PUC.LDSI.DataBase.Migrations
{
    public partial class Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    nome = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Turma",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    nome = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turma", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Avaliacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    professorId = table.Column<int>(nullable: false),
                    disciplina = table.Column<string>(type: "varchar(100)", nullable: false),
                    materia = table.Column<string>(type: "varchar(100)", nullable: false),
                    descricao = table.Column<string>(type: "varchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Avaliacao_Professor_professorId",
                        column: x => x.professorId,
                        principalTable: "Professor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    turmaId = table.Column<int>(nullable: false),
                    nome = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aluno_Turma_turmaId",
                        column: x => x.turmaId,
                        principalTable: "Turma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Publicacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    avalicaoId = table.Column<int>(type: "int", nullable: false),
                    turmaId = table.Column<int>(type: "int", nullable: false),
                    dataInicio = table.Column<DateTime>(type: "datetime", nullable: false),
                    dataFim = table.Column<DateTime>(type: "datetime", nullable: false),
                    valorProva = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publicacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Publicacao_Avaliacao_avalicaoId",
                        column: x => x.avalicaoId,
                        principalTable: "Avaliacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Publicacao_Turma_turmaId",
                        column: x => x.turmaId,
                        principalTable: "Turma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestaoAvaliacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    avaliacaoId = table.Column<int>(type: "int", nullable: false),
                    tipo = table.Column<int>(type: "int", nullable: false),
                    enunciado = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestaoAvaliacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestaoAvaliacao_Avaliacao_avaliacaoId",
                        column: x => x.avaliacaoId,
                        principalTable: "Avaliacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prova",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    avaliacaoId = table.Column<int>(type: "int", nullable: false),
                    alunoId = table.Column<int>(type: "int", nullable: false),
                    dataProva = table.Column<DateTime>(type: "datetime", nullable: false),
                    notaObtida = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prova", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prova_Aluno_alunoId",
                        column: x => x.alunoId,
                        principalTable: "Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prova_Avaliacao_avaliacaoId",
                        column: x => x.avaliacaoId,
                        principalTable: "Avaliacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OpcaoAvaliacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    questaoAvaliacaoId = table.Column<int>(nullable: false),
                    descricao = table.Column<string>(type: "varchar(250)", nullable: false),
                    verdadeira = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpcaoAvaliacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpcaoAvaliacao_QuestaoAvaliacao_questaoAvaliacaoId",
                        column: x => x.questaoAvaliacaoId,
                        principalTable: "QuestaoAvaliacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestaoProva",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    questaoAvaliacaoId = table.Column<int>(type: "int", nullable: false),
                    provaId = table.Column<int>(type: "int", nullable: false),
                    nota = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestaoProva", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestaoProva_Prova_provaId",
                        column: x => x.provaId,
                        principalTable: "Prova",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuestaoProva_QuestaoAvaliacao_questaoAvaliacaoId",
                        column: x => x.questaoAvaliacaoId,
                        principalTable: "QuestaoAvaliacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OpcaoProva",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    opcaoAvaliacaoId = table.Column<int>(type: "int", nullable: false),
                    questaoProvaId = table.Column<int>(type: "int", nullable: false),
                    resposta = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpcaoProva", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpcaoProva_OpcaoAvaliacao_opcaoAvaliacaoId",
                        column: x => x.opcaoAvaliacaoId,
                        principalTable: "OpcaoAvaliacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OpcaoProva_QuestaoProva_questaoProvaId",
                        column: x => x.questaoProvaId,
                        principalTable: "QuestaoProva",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_turmaId",
                table: "Aluno",
                column: "turmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacao_professorId",
                table: "Avaliacao",
                column: "professorId");

            migrationBuilder.CreateIndex(
                name: "IX_OpcaoAvaliacao_questaoAvaliacaoId",
                table: "OpcaoAvaliacao",
                column: "questaoAvaliacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_OpcaoProva_opcaoAvaliacaoId",
                table: "OpcaoProva",
                column: "opcaoAvaliacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_OpcaoProva_questaoProvaId",
                table: "OpcaoProva",
                column: "questaoProvaId");

            migrationBuilder.CreateIndex(
                name: "IX_Prova_alunoId",
                table: "Prova",
                column: "alunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Prova_avaliacaoId",
                table: "Prova",
                column: "avaliacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Publicacao_avalicaoId",
                table: "Publicacao",
                column: "avalicaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Publicacao_turmaId",
                table: "Publicacao",
                column: "turmaId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestaoAvaliacao_avaliacaoId",
                table: "QuestaoAvaliacao",
                column: "avaliacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestaoProva_provaId",
                table: "QuestaoProva",
                column: "provaId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestaoProva_questaoAvaliacaoId",
                table: "QuestaoProva",
                column: "questaoAvaliacaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OpcaoProva");

            migrationBuilder.DropTable(
                name: "Publicacao");

            migrationBuilder.DropTable(
                name: "OpcaoAvaliacao");

            migrationBuilder.DropTable(
                name: "QuestaoProva");

            migrationBuilder.DropTable(
                name: "Prova");

            migrationBuilder.DropTable(
                name: "QuestaoAvaliacao");

            migrationBuilder.DropTable(
                name: "Aluno");

            migrationBuilder.DropTable(
                name: "Avaliacao");

            migrationBuilder.DropTable(
                name: "Turma");

            migrationBuilder.DropTable(
                name: "Professor");
        }
    }
}
