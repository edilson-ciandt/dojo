using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Model
{
    public class Cartao
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdConta { get; set; }
        public double LimiteCartao { get; set; }
    }
}
