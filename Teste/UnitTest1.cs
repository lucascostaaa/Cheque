using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cheque.ConsoleApp;
namespace Teste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DoisCentavosPorExtenso()
        {
            string valor = "0.05";
            ChequeValorExtenso teste =  new ChequeValorExtenso()
            Assert.AreEqual(" cinco centavos de real", teste.Validar());
        }
    }
}
