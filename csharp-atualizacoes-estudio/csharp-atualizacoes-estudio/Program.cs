using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_6.V04;

namespace csharp_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno marty = new Aluno("Marty McFly", new DateTime(1968, 06, 12));
            Console.WriteLine(marty.Nome);
            Console.WriteLine(marty);
            Console.WriteLine(marty.Nome);

            Console.ReadKey();
        }
    }
}
