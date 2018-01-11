using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.String;
using static csharp_6.V10.Ano;

namespace csharp_6.V10
{
    //1. Vamos criar uma propriedade AnoNaEscola, que armazenará
    //um valor da enumeracao AnoEscolar:

    //public enum Ano
    //{
    //    Primeiro,
    //    Segundo,
    //    Terceiro,
    //    Quarto
    //}

    //class Aluno : INotifyPropertyChanged
    //{
    //    public string Nome { get; }
    //    public string Sobrenome { get; }

    //    private string endereco;
    //    public string Endereco
    //    {
    //        get { return endereco; }
    //        set
    //        {
    //            if (endereco != value)
    //            {
    //                endereco = value;
    //                PropertyChanged.Call(this);
    //                PropertyChanged.Call(this, nameof(DadosPessoais));
    //            }
    //        }
    //    }

    //    private string telefone;
    //    public string Telefone
    //    {
    //        get { return telefone; }
    //        set
    //        {
    //            if (telefone != value)
    //            {
    //                telefone = value;
    //                PropertyChanged.Call(this);
    //                PropertyChanged.Call(this, nameof(DadosPessoais));
    //            }
    //        }
    //    }

    //    public DateTime DataNascimento { get; } = new DateTime(1990, 1, 1);

    //    public string DadosPessoais =>
    //        Format("Nome: {0}, " +
    //            "Endereço: {1}, " +
    //            "Telefone: {2}", NomeCompleto, endereco, telefone);

    //    public Ano AnoNaEscola { get; set; }

    //    public int PontosDeExperiencia()
    //    {
    //        switch (AnoNaEscola)
    //        {
    //            case Ano.Primeiro:
    //                return 0;
    //            case Ano.Segundo:
    //                return 15;
    //            case Ano.Terceiro:
    //                return 65;
    //            case Ano.Quarto:
    //                return 80;
    //            default:
    //                return 0;
    //        }
    //    }

    //    public Aluno(string nome, string sobrenome)
    //    {
    //        this.Nome = nome;
    //        this.Sobrenome = sobrenome;
    //    }

    //    public Aluno(string nome, string sobrenome, DateTime dataNascimento)
    //        : this(nome, sobrenome)
    //    {
    //        this.DataNascimento = dataNascimento;
    //    }

    //    public Aluno(string nome, string sobrenome, DateTime dataNascimento, string endereco, string telefone)
    //        : this(nome, sobrenome, dataNascimento)
    //    {
    //        Endereco = endereco;
    //        Telefone = telefone;
    //    }

    //    public string NomeCompleto => Format("{0}, {1}", Nome, Sobrenome);

    //    public int GetIdade()
    //        => (int)((DateTime.Now - DataNascimento).TotalDays / 365.242199);

    //    public event PropertyChangedEventHandler PropertyChanged;
    //}

    //static class PropertyChangedExtensions
    //{
    //    public static void Call(this PropertyChangedEventHandler handler,
    //        object sender, [CallerMemberName] string propertyName = null)
    //    {
    //        if (handler != null)
    //        {
    //            handler.Invoke(sender, new PropertyChangedEventArgs(propertyName));
    //        }
    //    }
    //}














    //2. Agora podemos acessar diretamente os membros da enumeração
    //com using static Ano:
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
                    PropertyChanged.Call(this);
                    PropertyChanged.Call(this, nameof(DadosPessoais));
                }
            }
        }

        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set
            {
                if (telefone != value)
                {
                    telefone = value;
                    PropertyChanged.Call(this);
                    PropertyChanged.Call(this, nameof(DadosPessoais));
                }
            }
        }

        public DateTime DataNascimento { get; } = new DateTime(1990, 1, 1);

        public string DadosPessoais =>
            Format("Nome: {0}, " +
                "Endereço: {1}, " +
                "Telefone: {2}", NomeCompleto, endereco, telefone);

        public Ano AnoNaEscola { get; set; }

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

        public Aluno(string nome, string sobrenome, DateTime dataNascimento)
            : this(nome, sobrenome)
        {
            this.DataNascimento = dataNascimento;
        }

        public Aluno(string nome, string sobrenome, DateTime dataNascimento, string endereco, string telefone)
            : this(nome, sobrenome, dataNascimento)
        {
            Endereco = endereco;
            Telefone = telefone;
        }

        public string NomeCompleto => Format("{0}, {1}", Nome, Sobrenome);

        public int GetIdade()
            => (int)((DateTime.Now - DataNascimento).TotalDays / 365.242199);

        public event PropertyChangedEventHandler PropertyChanged;
    }

    static class PropertyChangedExtensions
    {
        public static void Call(this PropertyChangedEventHandler handler,
            object sender, [CallerMemberName] string propertyName = null)
        {
            if (handler != null)
            {
                handler.Invoke(sender, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

