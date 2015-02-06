using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banco.Model;
using Banco.Business;

namespace UnitTestBanco
{
    [TestClass]
    public class TestesCaixa
    {
        [TestMethod]
        public void TestarSaqueSemSaldo()
        {
            CaixaBusiness caixa= new CaixaBusiness();
            Conta conta = new Conta();

            conta.Saldo = 1000;
            conta.IdCliente = "123";

            Assert.IsFalse(caixa.Sacar(conta, 2000));
        }

        [TestMethod]
        public void TestarSaqueComSaldo()
        {
            CaixaBusiness caixa = new CaixaBusiness();
            Conta conta = new Conta();

            conta.Saldo = 1000;
            conta.IdCliente = "123";

            Assert.IsTrue(caixa.Sacar(conta, 500));
        }

        [TestMethod]
        public void TestarSaqueMenorQueValorMinimodeSaque()
        {

            CaixaBusiness caixa = new CaixaBusiness();
            Conta conta = new Conta();

            conta.Saldo = 1000;
            conta.IdCliente = "123";
            Assert.IsFalse(caixa.Sacar(conta, 0));
        }
    }
}
