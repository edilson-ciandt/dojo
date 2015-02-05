using CalculadoraSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hello2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            Console.WriteLine("{0}", calc.add(3,4));
            
        }
    }
}
