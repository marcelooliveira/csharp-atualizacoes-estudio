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
    //    public DateTime DataNascimento { get; }

    //    public Aluno(string nome, DateTime dataNascimento)
    //    {
    //        this.Nome = nome;
    //        this.DataNascimento = dataNascimento;
    //    }
    //}

    //2. A partir do C#6 podemos trabalhar com INICIALIZADORES de propriedades
    //automáticas (que na verdade são inicializadores dos campos privados readonly):
    class Aluno
    {
        public string Nome { get; }
        public DateTime DataNascimento { get; } = new DateTime(1990, 1, 1);

        public Aluno(string nome, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
        }
    }
}
