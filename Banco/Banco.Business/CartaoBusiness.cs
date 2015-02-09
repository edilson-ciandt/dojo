using Banco.Data;
using Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Business
{
    public class CartaoBusiness : IBusiness<Cartao>
    {
        public void Inserir(Cartao cartao)
        {
            IData<Cartao> cartaoData = new CartaoData();

            if (Verificar(cartao))
                cartaoData.Inserir(cartao);
        }

        public IEnumerable<Cartao> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Cartao BuscarPorId(int cartaoId)
        {
            return new CartaoData().BuscarPorId(cartaoId);
        }

        public void Excluir(int cartaoId)
        {
            new CartaoData().Excluir(cartaoId);
        }

        public void Atualizar(Cartao objeto)
        {
            new CartaoData().Atualizar(objeto);
        }

        public bool Verificar(Cartao cartao)
        {
            if (cartao.IdCliente > 0 &&
               cartao.IdConta > 0)
                return true;
            return false;
        }
    }

}
