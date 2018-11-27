using SolucaoPerformance1.Shared;
using System;
using System.IO;
using Xunit;

namespace SolucaoPerformance1
{
    // Compartilhando instância de objeto com todos os Métodos de Teste

    public class TesteObjetoCompartilhado : IClassFixture<BeforeMethodsTest>, IDisposable
    {

        BeforeMethodsTest beforeTests;

        public TesteObjetoCompartilhado(BeforeMethodsTest before)
        {
            beforeTests = before;
            File.AppendAllText(@"C:\BeforeTest.txt", "Inicio do Teste!" + Environment.NewLine);
        }

        public void Dispose()
        {
            File.AppendAllText(@"C:\BeforeTest.txt", "Fim do Teste!" + Environment.NewLine);
        }

        [Fact]
        public void Test1()
        {
            File.AppendAllText(@"C:\BeforeTest.txt", "Teste 1 - " + beforeTests.Pessoa.Nome.ToString() + "  -  " + beforeTests.Pessoa.Cpf.ToString() + Environment.NewLine);
        }

        [Fact]
        public void Test2()
        {
            File.AppendAllText(@"C:\BeforeTest.txt", "Teste 2 - " + beforeTests.Pessoa.Nome.ToString() + "  -  " + beforeTests.Pessoa.Cpf.ToString() + Environment.NewLine);
        }

        [Fact]
        public void Test3()
        {
            File.AppendAllText(@"C:\BeforeTest.txt", "Teste 3 - " + beforeTests.Pessoa.Nome.ToString() + "  -  " + beforeTests.Pessoa.Cpf.ToString() + Environment.NewLine);
        }
    }
}