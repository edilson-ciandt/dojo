using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Model
{
    public class Conta
    {
        public string Id { get; set; }
        public string IdCliente { get; set; }
        public string Senha { get; set; }
        public double Saldo { get; set; }
    }
}
