using Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Business
{
    public class ContaBusiness
    {
        public static bool VerificaIdClienteESenha(Conta conta) 
        {
            if (!String.IsNullOrEmpty(conta.IdCliente) &&
               !String.IsNullOrEmpty(conta.Senha))
                return true;
            return false;
        }

    }
}
