using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Model
{
    public class Conta
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Senha { get; set; }
        public decimal Saldo { get; set; }
    }
}
