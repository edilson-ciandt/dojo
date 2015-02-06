using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegate
{
    public delegate void OnQuiting();
    public delegate void PrintKey(char c);

    class KeyStrokeHandler
    {
        public event PrintKey OnKey;
        public event OnQuiting OnQuiting;

        public void Run()
        {
            Console.WriteLine("Iniciando...");

            while (true)
            {
                char key = Console.ReadKey(true).KeyChar;

                if (key == 'q')
                {
                    if (OnQuiting != null)
                        OnQuiting();

                    break;
                }

                if (key != null)
                    OnKey(key);
            }

        }
    }
}
