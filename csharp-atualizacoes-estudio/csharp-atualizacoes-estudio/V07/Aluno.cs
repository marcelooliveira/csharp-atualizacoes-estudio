using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_6.V07
{
    //1. Primeiro vamos adicionar propriedades Endereco e Telefone.
    //Em seguida, vamos criar um sistema de notificação na classe Aluno, para
    //notificar o cliente sempre que essas propriedade forem modificadas.
    //Para isso, é necessário implementar a interface INotifyPropertyChanged
    //class Aluno : INotifyPropertyChanged
    //{
    //    public string Nome { get; }
    //    public string Sobrenome { get; }
    //
    //private string endereco;
    //public string Endereco
    //{
    //    get { return endereco; }
    //    set { endereco = value; }
    //}
    //
    //private string telefone;
    //public string Telefone
    //{
    //    get { return telefone; }
    //    set { telefone = value; }
    //}

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

    //2. Agora vamos usar os setters das propriedades para notificar
    //os clientes sempre que o endereço ou o telefone forem modificados
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
    //                PropertyChanged(this, new PropertyChangedEventArgs("endereco"));
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
    //                PropertyChanged(this, new PropertyChangedEventArgs("telefone"));
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
    //Aluno marty = new Aluno("Marty", "McFly", new DateTime(1968, 06, 12));
    //marty.PropertyChanged += (sender, args) =>
    //{
    //    Console.WriteLine("O valor do {0} mudou!", args.PropertyName);
    //};
    //marty.Endereco = "9303 Lyon Drive Hill Valley CA";
    //marty.Telefone = "555-4385";

    //3. C# permite acessar diretamente o nome do campo através do operador nameof
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
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(endereco)));
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
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(telefone)));
                }
            }
        }

        public DateTime DataNascimento { get; } = new DateTime(1990, 1, 1);

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
}

