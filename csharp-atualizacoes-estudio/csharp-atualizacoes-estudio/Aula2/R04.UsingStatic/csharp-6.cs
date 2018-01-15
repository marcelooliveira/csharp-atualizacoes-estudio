using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.String;
using static System.DateTime;

namespace CSharp6.R04
{
    class Programa
    {
        public void Main()
        {
            Console.WriteLine("4. Using Static");
            Aluno marty = new Aluno("Marty", "McFly", new DateTime(1968, 06, 12))
            {
                Endereco = "9303 Lyon Drive Hill Valley CA",
                Telefone = "555-4385"
            };

            Console.WriteLine(marty.Nome);
            Console.WriteLine(marty.Sobrenome);
            Console.WriteLine(marty.DadosPessoais);
        }
    }

    public enum Ano
    {
        Primeiro,
        Segundo,
        Terceiro,
        Quarto
    }

    class Aluno
    {
        public string Nome { get; }
        public string Sobrenome { get; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public DateTime DataNascimento { get; } = new DateTime(1990, 1, 1);

        public Ano AnoNaEscola { get; set; } = Ano.Primeiro;

        public int PontosDeExperiencia()
        {
            switch (AnoNaEscola)
            {
                case Ano.Primeiro:
                    return 0;
                case Ano.Segundo:
                    return 15;
                case Ano.Terceiro:
                    return 65;
                case Ano.Quarto:
                    return 80;
                default:
                    return 0;
            }
        }

        public Aluno(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }

        public Aluno(string nome, string sobrenome, DateTime dataNascimento) : this(nome, sobrenome)
        {
            this.DataNascimento = dataNascimento;
        }

        public string NomeCompleto => Format("{0} {1}", Nome, Sobrenome);

        public int GetIdade()
            => (int)((Now - DataNascimento).TotalDays / 365.242199);

        public string DadosPessoais =>
            Format("Nome: {0}, " +
                "Endereço: {1}, " +
                "Telefone: {2}", NomeCompleto, Endereco, Telefone);
    }
}
