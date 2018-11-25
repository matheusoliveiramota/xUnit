using SolucaoPerformance1.Shared;
using System;
using System.IO;
using Xunit;

namespace SolucaoPerformance2
{
    // Objeto compartilhado com todas as CLASSES de teste
    [Collection("Pessoa collection")]
    public class Test2 : IDisposable
    {
        BeforeAllTestClasses beforeAllTest;

        public Test2(BeforeAllTestClasses before)
        {
            beforeAllTest = before;
            File.AppendAllText(@"C:\BeforeTestClasses.txt", "Inicio do Teste!" + Environment.NewLine);
        }

        public void Dispose()
        {
            File.AppendAllText(@"C:\BeforeTestClasses.txt", "Fim do Teste!" + Environment.NewLine);
        }

        [Fact]
        public void FirstTest()
        {
            File.AppendAllText(@"C:\BeforeTestClasses.txt", "Classe de Teste 2 - Teste 1 - Pessoa: " + beforeAllTest.Pessoa.Nome + "  -  " + beforeAllTest.Pessoa.Cpf + Environment.NewLine);
        }

        [Fact]
        public void SecondTest()
        {
            File.AppendAllText(@"C:\BeforeTestClasses.txt", "Classe de Teste 2 - Teste 2 - Pessoa: " + beforeAllTest.Pessoa.Nome + "  -  " + beforeAllTest.Pessoa.Cpf + Environment.NewLine);
        }
    }
}
