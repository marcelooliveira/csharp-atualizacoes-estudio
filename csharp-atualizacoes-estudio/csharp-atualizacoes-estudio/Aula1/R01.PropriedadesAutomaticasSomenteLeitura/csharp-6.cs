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
            Aluno marty = new Aluno("Marty", "McFly", new DateTime(1968, 06, 12))
                { Nome = "Biff", Sobrenome = "Tannen" };

            Console.WriteLine(marty.Nome);
            Console.WriteLine(marty.Sobrenome);
        }
    }

    class Aluno
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }

        public Aluno(string nome, string sobrenome, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.DataNascimento = dataNascimento;
        }
    }
}
