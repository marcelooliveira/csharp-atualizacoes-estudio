using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_6.V08
{
    //1. Podemos simplificar os eventos do INotifyPropertyChanged
    //Criando uma classe de extensão, sem nem precisar chamar o operador nameof,
    //usando CallerMemberName
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
    //            }
    //        }
    //    }

    //    public DateTime DataNascimento { get; } = new DateTime(1990, 1, 1);

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

    //    public string NomeCompleto => string.Format("{0}, {1}", Nome, Sobrenome);

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






    //2. Podemos ainda ter uma propriedade DadosPessoais,
    //para agrupar todas as informações do aluno:
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
            string.Format("Nome: {0}, " +
                "Endereço: {1}, " +
                "Telefone: {2}", NomeCompleto, endereco, telefone);
        
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

        public string NomeCompleto => string.Format("{0}, {1}", Nome, Sobrenome);

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

