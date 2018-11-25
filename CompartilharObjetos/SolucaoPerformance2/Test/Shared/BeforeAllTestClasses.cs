using PropostaOnline.GeradorPessoa;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SolucaoPerformance1.Shared
{
    public class BeforeAllTestClasses : IDisposable
    {
        public GeradorDePessoa Pessoa { get; private set; }

        public BeforeAllTestClasses()
        {
            // Instancia o objeto a ser compartilhado
            Pessoa = GeradorDePessoa.PreencherPropriedadesPessoa();
            File.AppendAllText(@"C:\BeforeTestClasses.txt", "Instanciando Pessoa para TODAS classes de teste!" + Environment.NewLine);
        }

        public void Dispose()
        {
            Pessoa = null;
            File.AppendAllText(@"C:\BeforeTestClasses.txt", "Fim dos testes de TODAS as Classes!" + Environment.NewLine);
        }
    }
}
