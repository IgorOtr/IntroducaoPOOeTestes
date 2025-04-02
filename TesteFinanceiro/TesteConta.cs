using Financeiro.Model;

namespace TesteFinanceiro
{
    [TestClass]
    public class TesteConta
    {
        [TestMethod]
        public void TestDeposito()
        {
            //cenário
            Conta conta1 = new Conta(123456, 50);
            decimal valorDeposito = 150;
            decimal saldoEsperado = 200;

            //ação
            conta1.Depositar(valorDeposito);


            //validação
            Assert.AreEqual(saldoEsperado, conta1.Saldo);
        }
    }
}
