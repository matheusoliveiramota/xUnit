using Newtonsoft.Json;
using PropostaOnline.GeradorPessoa;
using SolucaoPerformance1.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace SolucaoPerformance1
{
    // Compartilhando instância de objeto com todos os Métodos de Teste

    public class TesteObjetoCompartilhado : IClassFixture<BeforeMethodsTest>, IDisposable
    {
        // Lendo pessoas em arquivo JSON e populando planilha do Excel
        /*[Fact]
        public void PopulandoExcel()
        {
            string pathPessoaJSON = Directory.GetParent(Directory.GetParent
                                                            (Directory.GetParent(
                                                                Directory.GetCurrentDirectory()).FullName).FullName).FullName;
            pathPessoaJSON += "\\GeradorPessoa\\PessoaJSON\\";

            string[] json = new string[5];            
            for (int i = 0; i < 5; i++)
            {
                json[i] = File.ReadAllText(pathPessoaJSON + "GeradorPessoa" + (i + 1) + ".json");
            }

            List<GeradorDePessoa> listaPessoas1 = JsonConvert.DeserializeObject<List<GeradorDePessoa>>(json[0]);
            List<GeradorDePessoa> listaPessoas2 = JsonConvert.DeserializeObject<List<GeradorDePessoa>>(json[1]);
            List<GeradorDePessoa> listaPessoas3 = JsonConvert.DeserializeObject<List<GeradorDePessoa>>(json[2]);
            List<GeradorDePessoa> listaPessoas4 = JsonConvert.DeserializeObject<List<GeradorDePessoa>>(json[3]);
            List<GeradorDePessoa> listaPessoas5 = JsonConvert.DeserializeObject<List<GeradorDePessoa>>(json[4]);

            // Incluir no Excel: http://www.macoratti.net/12/10/c_mxls1.htm
        } */

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
