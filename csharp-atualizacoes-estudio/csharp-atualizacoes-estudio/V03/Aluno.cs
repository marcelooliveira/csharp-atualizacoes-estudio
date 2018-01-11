﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_6.V03
{
    //1. agora não podemos mudar o nome de fora da classe,
    //porém podemos mudar de DENTRO da classe, em um outro
    //método, por exemplo:
    //class Aluno
    //{
    //    public string Nome { get; private set; }
    //    public string Sobrenome { get; private set; }
    //    public DateTime DataNascimento { get; private set; }

    //    public Aluno(string nome, string sobrenome, DateTime dataNascimento)
    //    {
    //        this.Nome = nome;
    //        this.Sobrenome = sobrenome;
    //        this.DataNascimento = dataNascimento;
    //    }

    //    public override string ToString()
    //    {
    //        Nome = "Biff";
    //        Sobrenome = "Tannen";
    //        return Nome;
    //    }
    //}

    //2. Ainda não atingimos a verdadeira imutabilidade! Por quê?
    //Vamos mostrar o que o compilador está fazendo por trás dos panos
    //ilustrando com campos privados:
    class Aluno
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            private set { nome = value; }
        }

        private string sobrenome;
        public string Sobrenome
        {
            get { return sobrenome; }
            private set { sobrenome = value; }
        }

        public DateTime DataNascimento { get; private set; }

        public Aluno(string nome, string sobrenome, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.DataNascimento = dataNascimento;
        }
    }
}
