using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            NewTestDelegate nt1 = new NewTestDelegate();

            KeyStrokeHandler key1 = new KeyStrokeHandler();
            key1.OnKey += printing;
            key1.OnQuiting += Fechar;

            key1.Run();


        }

    

        static void printing(char c)
        {
            Console.WriteLine(c);
        }

        static void Fechar()
        {
            Console.WriteLine("Fechando");
        }

     
    }

    class NewTestDelegate
    {
        public string Name { get; set; }

        public void OnQuit()
        {
            Console.WriteLine("Quiting {0}", Name);
        }
    }
}
