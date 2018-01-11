using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_6.V08;

namespace csharp_6
{
    class Program
    {
        static void Main(string[] commandArgs)
        {
            Aluno marty = new Aluno("Marty", "McFly", new DateTime(1968, 06, 12));
            marty.PropertyChanged += (sender, args) =>
            {
                Console.WriteLine("O valor do {0} mudou!", args.PropertyName);
            };
            marty.Endereco = "9303 Lyon Drive Hill Valley CA";
            marty.Telefone = "555-4385";
            Console.ReadKey();
        }
    }
}
