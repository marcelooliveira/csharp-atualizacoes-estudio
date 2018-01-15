using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6.R02
{
    class Programa
    {
        public void Main()
        {
            Console.WriteLine("2. Inicializadores De Propriedade Automática");
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
        public string Nome { get; }
        public string Sobrenome { get; }
        public DateTime DataNascimento { get; }

        public Aluno(string nome, string sobrenome, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.DataNascimento = dataNascimento;
        }
    }
}
