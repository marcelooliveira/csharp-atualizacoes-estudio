using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_6.V06
{
    //1. vamos adicionar uma propriedade para obter o nome completo:
    //class Aluno
    //{
    //    public string Nome { get; }
    //    public string Sobrenome { get; }
    //    public DateTime DataNascimento { get; } = new DateTime(1990, 1, 1);

    //    public Aluno(string nome, string sobrenome, DateTime dataNascimento)
    //    {
    //        this.Nome = nome;
    //        this.Sobrenome = sobrenome;
    //        this.DataNascimento = dataNascimento;
    //    }

    //    public Aluno(string nome, string sobrenome)
    //    {
    //        this.Nome = nome;
    //        this.Sobrenome = sobrenome;
    //    }

    //    public string NomeCompleto
    //    {
    //        get { return Nome + Sobrenome; }
    //    }
    //}

    //2. Agora vamos criar um método para obter a idade do aluno:
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

        public string NomeCompleto
        {
            get { return Nome + Sobrenome; }
        }

        public int GetIdade()
        {
            return (int)((DateTime.Now - DataNascimento).TotalDays / 365.242199);
        }
    }
}
