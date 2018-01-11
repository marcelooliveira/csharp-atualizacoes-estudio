using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_6.V02
{
    class Aluno
    {
        //1. podemos criar membros imutáveis com campos auxiliares,
        //com getters mas sem setters:

        //private readonly string nome;
        //private readonly string sobrenome;
        //private readonly DateTime dataNascimento;

        //public string Nome { get { return nome; } }
        //public string Sobrenome { get { return sobrenome; } }
        //public DateTime DataNascimento { get { return dataNascimento; } }

        //public Aluno(string nome, string sobrenome, DateTime dataNascimento)
        //{
        //    this.nome = nome;
        //    this.sobrenome = sobrenome;
        //    this.dataNascimento = dataNascimento;
        //}

        //2. talvez campos auxiliares seja muito código. 
        //vamos tentar propriedades automáticas com private set

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public DateTime DataNascimento { get; private set; }

        public Aluno(string nome, string sobrenome, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.DataNascimento = dataNascimento;
        }
        //Legal, agora não podemos mais modificar o nome uma vez criado o objeto.

        //Aluno marty = new Aluno("Marty", "McFly", new DateTime(1968, 06, 12));
        //marty.Nome = "Biff";
        //marty.Sobrenome = "Tannen";
        //Error CS0272  The property or indexer 'Aluno.Nome' cannot be used in 
        //this context because the set accessor is inaccessible   
    }
}
