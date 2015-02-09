using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banco.Model;
using Banco.Business;

namespace UnitTestBanco
{
    [TestClass]
    public class TestesCartao
    {
        [TestMethod]
        public void VerificaIdClienteeIdContaSetados()
        {
            Cartao cartao = new Cartao();

            cartao.IdConta = 1;
            cartao.IdCliente = 1;

            Assert.IsTrue(new CartaoBusiness().Verificar(cartao));
        }

        [TestMethod]
        public void VerificaIdClienteIdContaComErros()
        {
            Cartao cartao = new Cartao();

            cartao.IdCliente =1;

            Assert.IsFalse(new CartaoBusiness().Verificar(cartao));
        }

        [TestMethod]
        public void CartaoDeveSerIncluidoELogoAposExcluido()
        {
            Cliente cliente = new Cliente();
            IBusiness<Cliente> clienteBusiness = new ClienteBusiness();

            cliente.Cpf = "234234234";
            cliente.DataDeNascimento = DateTime.Now;
            cliente.Endereco = "sdfasdf";
            cliente.Nome = "Edilson";

            clienteBusiness.Inserir(cliente);
            Assert.IsNotNull(cliente.Id);

            Cliente cliRetorno = clienteBusiness.BuscarPorId(cliente.Id);
            Assert.IsTrue(cliRetorno.Id > 0);


            IBusiness<Conta> contaBusiness = new ContaBusiness();

            var novaConta = new Conta
            {
                IdCliente = cliRetorno.Id,
                Saldo = Convert.ToDecimal(5000.04),
                Senha = "1234"

            };
            contaBusiness.Inserir(novaConta);

            var contaResult = contaBusiness.BuscarPorId(novaConta.Id);

            Assert.IsTrue(contaResult.Id > 0);


            IBusiness<Cartao> cartaoBusiness = new CartaoBusiness();
            var cartao = new Cartao{
                 IdCliente = cliRetorno.Id,
                  LimiteCartao = 500,
                    IdConta = contaResult.Id
                   
            };

            cartaoBusiness.Inserir(cartao);
            Assert.IsTrue(cartao.Id > 0);

            var cartaoResult = cartaoBusiness.BuscarPorId(cartao.Id);

            Assert.IsNotNull(cartaoResult);
            Assert.IsTrue(cartaoResult.Id >0);

            cartaoBusiness.Excluir(cartao.Id);

            cartaoResult = cartaoBusiness.BuscarPorId(cartao.Id);

            Assert.IsNull(cartaoResult);
          

            contaBusiness.Excluir(contaResult.Id);

            contaResult = contaBusiness.BuscarPorId(novaConta.Id);

            Assert.IsNull(contaResult);

            clienteBusiness.Excluir(cliRetorno.Id);

            var clienteResult = clienteBusiness.BuscarPorId(cliRetorno.Id);

            Assert.IsNull(clienteResult);
        }


    }
}
