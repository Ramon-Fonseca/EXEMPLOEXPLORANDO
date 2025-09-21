using System.Diagnostics.Tracing;
using System.Globalization;
using System.Threading.Channels;
using ExemploExplorando.Models;
using EXEMPLOEXPLORANDO.Models;
System.Globalization.CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("en-US");



ExemploExcecao exemplo = new ExemploExcecao();

exemplo.Metodo1();





















// try
// {

//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }

// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo nao encontrado: {ex.Message}");
// }

// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo nao encontrado: {ex.Message}");
// }

// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. Detalhes: {ex.Message}");
// }
// finally
// {


//     Console.WriteLine("Chegou ao fim do programa."); 
// }
















//DateTime dataAtual = DateTime.Now;

//Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));






//decimal ValorMonetario = 1582.40m;

//Console.WriteLine(ValorMonetario.ToString("C2"));

//double porcentagem = .3421;

//Console.WriteLine(porcentagem.ToString("P1"));


//int numero = 123456;
//Console.WriteLine(numero.ToString("##-##-##"));










//string numero1 = "10";
//string numero2 = "20";

//string resultado = numero1 + numero2;

//Console.WriteLine(resultado);
















//Pessoa pessoa1 = new Pessoa(nome: "Ramon", sobrenome: "Costa");

//Pessoa pessoa2 = new Pessoa(nome:"bruce", sobrenome:"wayne");

//Curso cursodeIngles = new Curso();
//cursodeIngles.Nome = "Inglês";
//cursodeIngles.Alunos = new List<Pessoa>();

///cursodeIngles.AdicionarAluno(pessoa1);
//cursodeIngles.AdicionarAluno(pessoa2);
//cursodeIngles.ListarAlunos();