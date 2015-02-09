using Banco.Data;
using Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Business
{
    public class ClienteBusiness:IBusiness<Cliente>
    {
        
        public bool Verificar(Cliente client)
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

        public void Inserir(Cliente objeto)
        {
            if (Verificar(objeto))
            {
                IData<Cliente> clienteData = new ClienteData();

                clienteData.Inserir(objeto);
            }
        }

        public IEnumerable<Cliente> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Cliente BuscarPorId(int clienteId)
        {

            IData<Cliente> clienteData = new ClienteData();

            return clienteData.BuscarPorId(clienteId);
        }

        public void Excluir(int clienteId)
        {
            IData<Cliente> clienteData = new ClienteData();

            clienteData.Excluir(clienteId);
        }

        public void Atualizar(Cliente objeto)
        {
            IData<Cliente> clienteData = new ClienteData();

            clienteData.Atualizar(objeto);
        }

    }
}
