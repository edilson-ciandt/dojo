using Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Business
{
    public class ClienteBusiness
    {
        
        public static bool VerifyUser(Cliente client)
        {
            if (!String.IsNullOrEmpty(client.Nome) &&
                !String.IsNullOrEmpty(client.Cpf) &&
                !String.IsNullOrEmpty(client.Endereco) &&
                client.DataDeNascimento != DateTime.MinValue)
            {
                return true;
            }

            return false;
        }
    }
}
