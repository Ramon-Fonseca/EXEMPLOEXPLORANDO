using System.Diagnostics.Tracing;
using EXEMPLOEXPLORANDO.Models;

Pessoa pessoa1 = new Pessoa(nome: "Ramon", sobrenome: "Costa");

Pessoa pessoa2 = new Pessoa(nome:"bruce", sobrenome:"wayne");

Curso cursodeIngles = new Curso();
cursodeIngles.Nome = "Inglês";
cursodeIngles.Alunos = new List<Pessoa>();

cursodeIngles.AdicionarAluno(pessoa1);
cursodeIngles.AdicionarAluno(pessoa2);
cursodeIngles.ListarAlunos();