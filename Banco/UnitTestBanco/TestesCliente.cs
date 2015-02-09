using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banco.Model;
using Banco.Business;


namespace UnitTestBanco
{
    [TestClass]
    public class TestesCliente
    {
        [TestMethod]
        public void TesteVerificaClienteDeveRetornarFalso()
        {
            Cliente cliente = new Cliente();

            Assert.IsFalse(new ClienteBusiness().Verificar(cliente));
   
        }

        [TestMethod]
        public void TesteVerificaClienteDeveRetornarTrue()
        {
            Cliente cliente = new Cliente();

            cliente.Nome = "Joao";
            cliente.Cpf = "12345678911";
            cliente.DataDeNascimento = DateTime.Now;
            cliente.Endereco = "lugar";

            Assert.IsTrue(new ClienteBusiness().Verificar(cliente));
        }

        [TestMethod]
        public void TesteVerificaClienteDeveRetornarFalseComUmCampoEmBranco()
        {
            Cliente cliente = new Cliente();

            cliente.Cpf = "12345678911";
            cliente.DataDeNascimento = DateTime.Now;
            cliente.Endereco = "lugar";

            Assert.IsFalse(new ClienteBusiness().Verificar(cliente));
        }

        [TestMethod]
        public void TesteVerificaInsercaoBuscaeRemocao()
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
            Assert.IsNotNull(cliRetorno);

            clienteBusiness.Excluir(cliente.Id);
            Assert.IsNull(clienteBusiness.BuscarPorId(cliente.Id));
        }

        [TestMethod]
        public void TesteVerificaUpdate()
        {
            Cliente cliente = new Cliente { Id = 1 };
            IBusiness<Cliente> clienteBusiness = new ClienteBusiness();

            cliente.Cpf = "0000";
            cliente.DataDeNascimento = DateTime.Now;
            cliente.Endereco = "algo";
            cliente.Nome = "Alguem";

            clienteBusiness.Atualizar(cliente);
            Assert.AreEqual("0000",clienteBusiness.BuscarPorId(cliente.Id).Cpf);



        }
        


    }
}
