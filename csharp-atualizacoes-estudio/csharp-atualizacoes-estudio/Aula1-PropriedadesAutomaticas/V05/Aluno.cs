using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_6.V05
{
    ////1. voltamos à propriedades getter-only:
    //class Aluno
    //{
    //    public string Nome { get; }
    //    public string Sobrenome { get; }
    //    public DateTime DataNascimento { get; }

    //    public Aluno(string nome, string sobrenome, DateTime dataNascimento)
    //    {
    //        this.Nome = nome;
    //        this.Sobrenome = sobrenome;
    //        this.DataNascimento = dataNascimento;
    //    }
    //}

    ////2. E se tivermos construtor com somente alguns dos parâmetros? 
    //class Aluno
    //{
    //    public string Nome { get; }
    //    public string Sobrenome { get; }
    //    public DateTime DataNascimento { get; }

    //    public Aluno(string nome, string sobrenome, DateTime dataNascimento)
    //    {
    //        this.Nome = nome;
    //        this.Sobrenome = sobrenome;
    //        this.DataNascimento = dataNascimento;
    //    }
    //
    //    public Aluno(string nome, string sobrenome)
    //    {
    //        this.Nome = nome;
    //        this.Sobrenome = sobrenome;
    //    }
    //}

    //3. Nesse caso podemos inicializar as propriedades não definidas no construtor.
    //A partir do C#6 podemos trabalhar com INICIALIZADORES de propriedades
    //automáticas (que na verdade são inicializadores dos campos privados readonly):
    class Aluno
    {
        public string Nome { get; }
        public string Sobrenome { get; }
        public DateTime DataNascimento { get; } = new DateTime(1990, 1, 1);

        public Aluno(string nome, string sobrenome, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.DataNascimento = dataNascimento;
        }

        public Aluno(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }
    }
}
