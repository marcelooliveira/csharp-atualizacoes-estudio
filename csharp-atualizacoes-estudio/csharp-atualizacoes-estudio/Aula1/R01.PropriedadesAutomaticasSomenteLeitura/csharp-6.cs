using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6.R01
{
    class Programa
    {
        public void Main()
        {
            Console.WriteLine("1. Propriedades Automáticas Somente-Leitura");
            Aluno marty = new Aluno("Marty", "McFly", new DateTime(1968, 06, 12));

            Console.WriteLine(marty.Nome);
            Console.WriteLine(marty.Sobrenome);
        }
    }

    class Aluno
    {
        private readonly string nome;
        private readonly string sobrenome;
        private readonly DateTime dataNascimento;

        public string Nome { get { return nome; } }
        public string Sobrenome { get { return sobrenome; } }
        public DateTime DataNascimento { get { return dataNascimento; } }

        public Aluno(string nome, string sobrenome, DateTime dataNascimento)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.dataNascimento = dataNascimento;
        }
    }
}
