using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banco.Model;
using Banco.Business;

namespace UnitTestBanco
{
    [TestClass]
    public class TestesConta
    {
        [TestMethod]
        public void ContaSemSenhaEIdCliente()
        {
            Conta conta = new Conta();
            Assert.IsFalse(new ContaBusiness().Verificar(conta));
        }

        [TestMethod]
        public void ContaComSenhaEIdCliente()
        {
            Conta conta = new Conta();
            conta.IdCliente = 1;
            conta.Senha = "Suporte;123";
            Assert.IsTrue(new ContaBusiness().Verificar(conta));
        }

        [TestMethod]
        public void ContaSemIdCliente()
        {
            Conta conta = new Conta();
            conta.Senha = "Suporte;123";
            Assert.IsFalse(new ContaBusiness().Verificar(conta));
        }


        [TestMethod]
        public void ContaDeveInserirELogoAposExcluirRegistro()
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
            Assert.IsTrue(cliRetorno.Id  >0);


            IBusiness<Conta> contaBusiness = new ContaBusiness();

            var novaConta = new Conta
            {
                IdCliente = cliRetorno.Id,
                Saldo = Convert.ToDecimal(5000.04),
                Senha = "1234"

            };
            contaBusiness.Inserir(novaConta);

            var contaResult = contaBusiness.BuscarPorId(novaConta.Id);

            Assert.IsTrue(contaResult.Id >0);

            contaBusiness.Excluir(contaResult.Id);

            contaResult = contaBusiness.BuscarPorId(novaConta.Id);

            Assert.IsNull(contaResult);

            clienteBusiness.Excluir(cliRetorno.Id);

            var clienteResult = clienteBusiness.BuscarPorId(cliRetorno.Id);

            Assert.IsNull(clienteResult);
            

        }

    }
}
