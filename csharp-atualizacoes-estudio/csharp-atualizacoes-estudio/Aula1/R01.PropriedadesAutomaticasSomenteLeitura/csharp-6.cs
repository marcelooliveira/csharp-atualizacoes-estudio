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
            //marty.Nome = "Biff";
            //marty.Sobrenome = "Tannen";
            //Error CS0272  The property or indexer 'Aluno.Nome' cannot be used in 
            //this context because the set accessor is inaccessible   

            Console.WriteLine(marty.Nome);
            Console.WriteLine(marty.Sobrenome);
        }
    }

    class Aluno
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public DateTime DataNascimento { get; private set; }

        public Aluno(string nome, string sobrenome, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.DataNascimento = dataNascimento;
        }
    }
}
