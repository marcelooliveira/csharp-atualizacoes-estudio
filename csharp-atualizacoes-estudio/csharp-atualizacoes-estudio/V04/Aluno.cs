using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_6.V04
{
    //1. Com C# 6, podemos deixar as propriedades somente com getter e sem setter!
    //class Aluno
    //{
    //    public string Nome { get;  }
    //    public string Sobrenome { get;  }
    //    public DateTime DataNascimento { get; }

    //    public Aluno(string nome, string sobrenome, DateTime dataNascimento)
    //    {
    //        this.Nome = nome;
    //        this.Sobrenome = sobrenome;
    //        this.DataNascimento = dataNascimento;
    //    }

    //    public override string ToString()
    //    {
    //        //Nome = "Tannen";
    //        //Sobrenome = "Biff";
    //        //a linha acima gera um ERRO:
    //        //error CS0200: Property or indexer 'Aluno.Nome' cannot be assigned to --it is read only
    //        return Nome;
    //    }
    //}

    //2. por que tomamos o erro CS0200 acima no método ToString() mas não no construtor?
    //porque no Construtor, não estamos atribuindo o valor à propriedade, mas sim 
    //ao campo privado que é gerado por trás dos panos!
    //Esse campo readonly só pode ser definido no construtor!
    //O código acima é equivalente ao abaixo:
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
