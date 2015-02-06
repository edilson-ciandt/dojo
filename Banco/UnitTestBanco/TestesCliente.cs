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

            Assert.IsFalse(ClienteBusiness.VerifyUser(cliente));
   
        }

        [TestMethod]
        public void TesteVerificaClienteDeveRetornarTrue()
        {
            Cliente cliente = new Cliente();

            cliente.Nome = "Joao";
            cliente.Cpf = "12345678911";
            cliente.DataDeNascimento = DateTime.Now;
            cliente.Endereco = "lugar";

            Assert.IsTrue(ClienteBusiness.VerifyUser(cliente));
        }

        [TestMethod]
        public void TesteVerificaClienteDeveRetornarFalseComUmCampoEmBranco()
        {
            Cliente cliente = new Cliente();

            cliente.Cpf = "12345678911";
            cliente.DataDeNascimento = DateTime.Now;
            cliente.Endereco = "lugar";

            Assert.IsFalse(ClienteBusiness.VerifyUser(cliente));
        }
    }
}
