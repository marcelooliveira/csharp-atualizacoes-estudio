using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.String;
using static System.DateTime;
using static CSharp6.R07.Ano;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CSharp6.R07
{
    class Programa
    {
        public void Main()
        {
            Console.WriteLine("7. Expressões nameOf");

            Aluno marty = new Aluno("Marty", "McFly", new DateTime(1968, 06, 12))
            {
                Endereco = "9303 Lyon Drive Hill Valley CA",
                Telefone = "555-4385"
            };

            Console.WriteLine(marty.Nome);
            Console.WriteLine(marty.Sobrenome);
            Console.WriteLine(marty.DadosPessoais);

            Avaliacao melhorAvaliacao = GetMelhorNota(marty);

            Console.WriteLine("Melhor Nota: {0}", melhorAvaliacao?.Nota);

            marty.AdicionarAvaliacao(new Avaliacao(1, "Geografia", 8));
            marty.AdicionarAvaliacao(new Avaliacao(1, "Matemática", 6));
            marty.AdicionarAvaliacao(new Avaliacao(1, "História", 7));

            melhorAvaliacao = GetMelhorNota(marty);

            Console.WriteLine("Melhor Nota: {0}", melhorAvaliacao?.Nota);

            marty.PropertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine($"Propriedade {eventArgs.PropertyName} mudou!");
            };
            marty.Endereco = "novo endereço";
            marty.Telefone = "7777777";
        }

        private static Avaliacao GetMelhorNota(Aluno marty)
        {
            return marty.Avaliacoes
                .OrderByDescending(a => a.Nota)
                .FirstOrDefault();
        }
    }

    public enum Ano
    {
        Primeiro,
        Segundo,
        Terceiro,
        Quarto
    }

    class Aluno : INotifyPropertyChanged
    {
        public string Nome { get; }
        public string Sobrenome { get; }

        private string endereco;
        public string Endereco
        {
            get { return endereco; }
            set
            {
                if (endereco != value)
                {
                    endereco = value;

                    //if (PropertyChanged != null)
                    //{
                    //    PropertyChanged(this, new PropertyChangedEventArgs("Endereco"));
                    //}

                    //
                    //refatorado para a linha abaixo!
                    //
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Endereco)));

                }
            }
        }

        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set
            {
                telefone = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Telefone)));
            }
        }

        public DateTime DataNascimento { get; } = new DateTime(1990, 1, 1);

        public Ano AnoNaEscola { get; set; } = Primeiro;

        public int PontosDeExperiencia()
        {
            switch (AnoNaEscola)
            {
                case Primeiro:
                    return 0;
                case Segundo:
                    return 15;
                case Terceiro:
                    return 65;
                case Quarto:
                    return 80;
                default:
                    return 0;
            }
        }

        public Aluno(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }

        public Aluno(string nome, string sobrenome, DateTime dataNascimento) : this(nome, sobrenome)
        {
            this.DataNascimento = dataNascimento;
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public int GetIdade()
            => (int)((Now - DataNascimento).TotalDays / 365.242199);

        public string DadosPessoais =>
            $"Nome: {NomeCompleto}, " +
            $"Nascimento: {DataNascimento:dd/MM/yyyy}, " +
            $"Endereço: {Endereco}, " +
            $"Telefone: {Telefone}";

        private IList<Avaliacao> avaliacoes = new List<Avaliacao>();

        public event PropertyChangedEventHandler PropertyChanged;

        public IReadOnlyCollection<Avaliacao> Avaliacoes
            => new ReadOnlyCollection<Avaliacao>(avaliacoes);

        public void AdicionarAvaliacao(Avaliacao avaliacao)
        {
            avaliacoes.Add(avaliacao);
        }
    }



    class Avaliacao
    {
        public Avaliacao(int bimestre, string materia, double nota)
        {
            Bimestre = bimestre;
            Materia = materia;
            Nota = nota;
        }

        public int Bimestre { get; }
        public string Materia { get; }
        public double Nota { get; }
    }

}
