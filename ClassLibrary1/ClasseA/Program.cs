using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseA
{
    class Program
    {
        static void Main(string[] args)
        {

            string x= "bla";
            Cachorro cachorro = new Cachorro();
            cachorro.Nome = "C";

            
            Console.WriteLine(cachorro.Nome);
            cachorro.Nome = x;
            cachorro.AlterarNome(cachorro);
            Console.WriteLine(cachorro.Nome);
            Console.WriteLine(x);
     


        }
    }

    public class Cachorro
    {
        public string Nome;

        public void AlterarNome(Cachorro cachorro)
        {
            cachorro.Nome = "Auau";
        }
    }

  

}
