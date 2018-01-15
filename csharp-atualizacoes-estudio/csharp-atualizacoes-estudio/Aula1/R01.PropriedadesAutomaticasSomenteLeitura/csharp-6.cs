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
        private readonly string nome;
        public string Nome { get { return nome; } }
        public string Sobrenome { get; }
        public DateTime DataNascimento { get; }

        public Aluno(string nome, string sobrenome, DateTime dataNascimento)
        {
            this.nome = nome;
            this.Sobrenome = sobrenome;
            this.DataNascimento = dataNascimento;
        }

        public override string ToString()
        {
            //Nome = "Biff";
            //Sobrenome = "Tannen";
            //a linha acima gera um ERRO:
            //error CS0200: Property or indexer 'Aluno.Nome' cannot be assigned to --it is read only
            return Nome;
        }
    }
}
