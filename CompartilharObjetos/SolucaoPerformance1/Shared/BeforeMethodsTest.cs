using PropostaOnline.GeradorPessoa;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SolucaoPerformance1.Shared
{
    public class BeforeMethodsTest : IDisposable
    {
        public GeradorDePessoa Pessoa { get; private set; }

        public BeforeMethodsTest()
        {
            File.AppendAllText(@"C:\BeforeTest.txt", "Instanciando Pessoa para nova classe de teste!" + Environment.NewLine);
            // Instancia o objeto a ser compartilhado
            Pessoa = GeradorDePessoa.PreencherPropriedadesPessoa();
        }

        public void Dispose()
        {
            File.AppendAllText(@"C:\BeforeTest.txt", "Fim de todos os testes da classe !" + Environment.NewLine);
            Pessoa = null;
        }
    }
}
