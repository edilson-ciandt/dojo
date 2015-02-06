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
            Assert.IsFalse(ContaBusiness.VerificaIdClienteESenha(conta));
        }

        [TestMethod]
        public void ContaComSenhaEIdCliente()
        {
            Conta conta = new Conta();
            conta.IdCliente = "1";
            conta.Senha = "Suporte;123";
            Assert.IsTrue(ContaBusiness.VerificaIdClienteESenha(conta));
        }

        [TestMethod]
        public void ContaSemIdCliente()
        {
            Conta conta = new Conta();
            conta.Senha = "Suporte;123";
            Assert.IsFalse(ContaBusiness.VerificaIdClienteESenha(conta));
        }
        



    }
}
