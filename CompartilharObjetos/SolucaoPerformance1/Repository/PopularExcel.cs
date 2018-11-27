using ClosedXML.Excel;
using Newtonsoft.Json;
using PropostaOnline.GeradorPessoa;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SolucaoPerformance1.Repository
{
    public static class PopularExcel
    {
        public static void InserirPessoaJSON()
        {
            string pathPessoaJSON = Directory.GetParent(Directory.GetParent
                                                    (Directory.GetParent(
                                                        Directory.GetCurrentDirectory()).FullName).FullName).FullName;
            pathPessoaJSON += "\\GeradorPessoa\\PessoaJSON\\";

            string[] json = new string[5];            
            for (int i = 0; i< 5; i++)
            {
                json[i] = File.ReadAllText(pathPessoaJSON + "GeradorPessoa" + (i + 1) + ".json");
            }

            List<GeradorDePessoa> listaPessoas = JsonConvert.DeserializeObject<List<GeradorDePessoa>>(json[0]);
            listaPessoas.AddRange(JsonConvert.DeserializeObject<List<GeradorDePessoa>>(json[1]));
                                          listaPessoas.AddRange(JsonConvert.DeserializeObject<List<GeradorDePessoa>>(json[2]));
                                          listaPessoas.AddRange(JsonConvert.DeserializeObject<List<GeradorDePessoa>>(json[3]));
                                          listaPessoas.AddRange(JsonConvert.DeserializeObject<List<GeradorDePessoa>>(json[4]));

            int linha = 2;
            foreach (var pessoa in listaPessoas)
            {
                var wb = new XLWorkbook(@"C:\Users\mmota\Documents\CONRADO\Planilha_Teste.xlsx");// diretorio da planilha
                string dirProjectPropostaOnline = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName;
                var planilha = wb.Worksheet("PESSOAS");// qual sheet abrir possivel passar a posição ou o Nome da Planilha

                planilha.Cell("A" + (linha).ToString()).SetValue(pessoa.Nome);
                planilha.Cell("B" + (linha).ToString()).SetValue(pessoa.Cpf);
                planilha.Cell("C" + (linha).ToString()).SetValue(pessoa.Idade);
                planilha.Cell("D" + (linha).ToString()).SetValue(pessoa.Rg);
                planilha.Cell("E" + (linha).ToString()).SetValue(pessoa.Email);
                planilha.Cell("F" + (linha).ToString()).SetValue(pessoa.DataNascimento);
                planilha.Cell("G" + (linha).ToString()).SetValue(pessoa.Sexo);
                planilha.Cell("H" + (linha).ToString()).SetValue(pessoa.Endereco.Cep);
                planilha.Cell("I" + (linha).ToString()).SetValue(pessoa.Endereco.Rua);
                planilha.Cell("J" + (linha).ToString()).SetValue(pessoa.Endereco.Numero);
                planilha.Cell("K" + (linha).ToString()).SetValue(pessoa.Endereco.Bairro);
                planilha.Cell("L" + (linha).ToString()).SetValue(pessoa.Endereco.UF);
                planilha.Cell("M" + (linha).ToString()).SetValue(pessoa.Endereco.Cidade);
                planilha.Cell("N" + (linha).ToString()).SetValue(pessoa.DDDTel);
                planilha.Cell("O" + (linha).ToString()).SetValue(pessoa.Telefone);
                planilha.Cell("P" + (linha).ToString()).SetValue(pessoa.DDDCelular);
                planilha.Cell("Q" + (linha).ToString()).SetValue(pessoa.Celular);

                linha++;
            }
        }
    }
}
