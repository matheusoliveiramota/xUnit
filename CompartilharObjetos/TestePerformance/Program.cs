using ClosedXML.Excel;
using PropostaOnline.GeradorPessoa;
using System;

namespace TestePerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime inicio = DateTime.Now;

            for (int i = 2; i <= 22; i++)
            {
                var wb = new XLWorkbook(@"C:\Users\mmota\Documents\CONRADO\Planilha_Teste.xlsx");// diretorio da planilha
                var planilha = wb.Worksheet("PESSOAS");// qual sheet abrir possivel passar a posição ou o Nome da Planilha
                int linha = i;

                GeradorDePessoa gerador = new GeradorDePessoa();
                gerador.Endereco = new Endereco();

                gerador.Nome = planilha.Cell("A" + linha.ToString()).Value.ToString();
                gerador.Cpf = planilha.Cell("B" + linha.ToString()).Value.ToString();
                gerador.Idade = Convert.ToInt32(planilha.Cell("C" + linha.ToString()).Value);
                gerador.Rg = planilha.Cell("D" + linha.ToString()).Value.ToString();
                gerador.Email = planilha.Cell("E" + linha.ToString()).Value.ToString();
                gerador.DataNascimento = planilha.Cell("F" + linha.ToString()).Value.ToString();
                gerador.Sexo = planilha.Cell("G" + linha.ToString()).Value.ToString();
                gerador.Endereco.Cep = planilha.Cell("H" + linha.ToString()).Value.ToString();
                gerador.Endereco.Rua = planilha.Cell("I" + linha.ToString()).Value.ToString();
                gerador.Endereco.Numero = planilha.Cell("J" + linha.ToString()).Value.ToString();
                gerador.Endereco.Bairro = planilha.Cell("K" + linha.ToString()).Value.ToString();
                gerador.Endereco.UF = planilha.Cell("L" + linha.ToString()).Value.ToString();
                gerador.Endereco.Cidade = planilha.Cell("M" + linha.ToString()).Value.ToString();
                gerador.DDDTel = planilha.Cell("N" + linha.ToString()).Value.ToString();
                gerador.Telefone = planilha.Cell("O" + linha.ToString()).Value.ToString();
                gerador.DDDCelular = planilha.Cell("P" + linha.ToString()).Value.ToString();
                gerador.Celular = planilha.Cell("Q" + linha.ToString()).Value.ToString();
            }

            Console.WriteLine("Diferença instanciando várias vezes: " + (DateTime.Now - inicio));

            DateTime inicio2 = DateTime.Now;
            var wb2 = new XLWorkbook(@"C:\Users\mmota\Documents\CONRADO\Planilha_Teste.xlsx");// diretorio da planilha
            for (int i = 2; i <= 22; i++)
            {
                var planilha = wb2.Worksheet("PESSOAS");// qual sheet abrir possivel passar a posição ou o Nome da Planilha
                int linha = i;

                GeradorDePessoa gerador = new GeradorDePessoa();
                gerador.Endereco = new Endereco();
                gerador.Nome = planilha.Cell("A" + linha.ToString()).Value.ToString();
                gerador.Cpf = planilha.Cell("B" + linha.ToString()).Value.ToString();
                gerador.Idade = Convert.ToInt32(planilha.Cell("C" + linha.ToString()).Value);
                gerador.Rg = planilha.Cell("D" + linha.ToString()).Value.ToString();
                gerador.Email = planilha.Cell("E" + linha.ToString()).Value.ToString();
                gerador.DataNascimento = planilha.Cell("F" + linha.ToString()).Value.ToString();
                gerador.Sexo = planilha.Cell("G" + linha.ToString()).Value.ToString();
                gerador.Endereco.Cep = planilha.Cell("H" + linha.ToString()).Value.ToString();
                gerador.Endereco.Rua = planilha.Cell("I" + linha.ToString()).Value.ToString();
                gerador.Endereco.Numero = planilha.Cell("J" + linha.ToString()).Value.ToString();
                gerador.Endereco.Bairro = planilha.Cell("K" + linha.ToString()).Value.ToString();
                gerador.Endereco.UF = planilha.Cell("L" + linha.ToString()).Value.ToString();
                gerador.Endereco.Cidade = planilha.Cell("M" + linha.ToString()).Value.ToString();
                gerador.DDDTel = planilha.Cell("N" + linha.ToString()).Value.ToString();
                gerador.Telefone = planilha.Cell("O" + linha.ToString()).Value.ToString();
                gerador.DDDCelular = planilha.Cell("P" + linha.ToString()).Value.ToString();
                gerador.Celular = planilha.Cell("Q" + linha.ToString()).Value.ToString();
            }

            Console.WriteLine("Diferença instanciando UMA vezes: " + (DateTime.Now - inicio2));
        }
    }
}