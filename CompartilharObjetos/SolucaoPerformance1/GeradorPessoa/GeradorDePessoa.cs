using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace PropostaOnline.GeradorPessoa
{
    public class GeradorDePessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }
        public string Rg { get; set; }
        public string Email { get; set; }
        public string DataNascimento { get; set; }
        public string Sexo { get; set; }
        public Endereco Endereco { get; set; }
        public string DDDTel { get; set; }
        public string Telefone { get; set; }
        public string DDDCelular { get; set; }
        public string Celular { get; set; }

        public static GeradorDePessoa PreencherPropriedadesPessoa()
        {
            Random random = new Random();
            int numeroArquivoJSON = random.Next(1,6);
            int numeroPosicaoPessoa = random.Next(0,100);

            string dirProjectPropostaOnline = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName).FullName;
            StreamReader sr = new StreamReader(dirProjectPropostaOnline + "\\SolucaoPerformance1\\GeradorPessoa\\PessoaJSON\\GeradorPessoa" + numeroArquivoJSON.ToString() + ".json");
            List<GeradorDePessoa> lista = JsonConvert.DeserializeObject<List<GeradorDePessoa>>(sr.ReadToEnd());
            return lista[numeroPosicaoPessoa];
        }
    }
}