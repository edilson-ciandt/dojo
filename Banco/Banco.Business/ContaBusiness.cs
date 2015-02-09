using Banco.Data;
using Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Business
{
    public class ContaBusiness : IBusiness<Conta>
    {
        public bool Verificar(Conta conta)
        {
            if (conta.IdCliente > 0 &&
               !String.IsNullOrEmpty(conta.Senha))
                return true;
            return false;
        }


        public void Inserir(Conta conta)
        {
            IData<Conta> contaData = new ContaData();
            if (Verificar(conta))
                contaData.Inserir(conta);
        }

        public IEnumerable<Conta> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Conta BuscarPorId(int idConta)
        {
            IData<Conta> contaData = new ContaData();
            return contaData.BuscarPorId(idConta);
        }

        public void Excluir(int idConta)
        {
            IData<Conta> contaData = new ContaData();
            contaData.Excluir(idConta);
        }

        public void Atualizar(Conta conta)
        {
            throw new NotImplementedException();
        }
    }
}
