using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_6.V01;

namespace csharp_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno marty = new Aluno("Marty McFly", new DateTime(1968, 06, 12)) 
                { Nome = "Biff Tannen" }; 
        }
    }
}
