using Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Business
{

    public class CaixaBusiness
    {

        public bool Sacar(Conta conta, decimal valor)
        {
            if ((conta.Saldo >= valor)&&(valor>=50)) {
               
                conta.Saldo = conta.Saldo - valor;
                return true;
            }

            return false;

        }
    }
}
