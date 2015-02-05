using System;
using PacoteNegocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PalindromeTeste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerificaPalindrome()
        {
            String palavra = "a na";

            Negocio n = new Negocio();

            Boolean resultado = n.VerificaPalindrome(palavra);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void VerificaPalindromeFalse()
        {
            String palavra = "bolo";

            Negocio n = new Negocio();

            Boolean resultado = n.VerificaPalindrome(palavra);
            Assert.IsFalse(resultado);
        }
    }


}
