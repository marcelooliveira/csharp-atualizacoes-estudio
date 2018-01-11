using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_6.V01
{
    //1. SOMENTE CAMPOS, SEM PROPRIEDADES
    //class Aluno
    //{
    //    private string nome;
    //    private DateTime dataNascimento;

    //    public Aluno(string nome, DateTime dataNascimento)
    //    {
    //        this.nome = nome;
    //        this.dataNascimento = dataNascimento;
    //    }
    //}

    //2. DE CAMPOS PARA PROPRIEDADES AUTOMÁTICAS

    class Aluno
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public Aluno(string nome, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
        }
    }

    //Mas isso permitiria modificar o nome após a criação, o que não é nada bom!
    //Aluno marty = new Aluno("Marty McFly", new DateTime(1968, 06, 12))
    //        { Nome = "Biff Tannen" };


}
