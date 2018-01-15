﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6.R03
{
    class Programa
    {
        public void Main()
        {
            Console.WriteLine("3. Membros Com Corpo De Expressão");
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
        public DateTime DataNascimento { get; } = new DateTime(1990, 1, 1);

        public Aluno(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }

        public Aluno(string nome, string sobrenome, DateTime dataNascimento) : this(nome, sobrenome)
        {
            this.DataNascimento = dataNascimento;
        }

        public string NomeCompleto => string.Format("{0} {1}", Nome, Sobrenome);

        public int GetIdade()
            => (int)((DateTime.Now - DataNascimento).TotalDays / 365.242199);
    }
}
