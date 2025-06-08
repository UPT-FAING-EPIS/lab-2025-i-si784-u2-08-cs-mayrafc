using TechTalk.SpecFlow;
using NUnit.Framework;
using Calculator.Domain;
using System;

namespace Calculator.Domain.Tests.Steps
{
    [Binding]
    public class CuentaAhorroPruebas
    {
        private CuentaAhorro? cuenta;
        private Exception? excepcion;

        [Given(@"la nueva cuenta numero (\d+) con saldo (\d+)")]
        public void DadoLaNuevaCuentaNumeroConSaldo(int numero, decimal saldo)
        {
            cuenta = new CuentaAhorro(saldo);
            excepcion = null;
        }

        [When(@"el cliente cancela la cuenta")]
        public void CuandoElClienteCancelaLaCuenta()
        {
            try
            {
                cuenta!.Cancelar();
            }
            catch (Exception ex)
            {
                excepcion = ex;
            }
        }

        [Then(@"la cuenta debe estar cancelada")]
        public void EntoncesLaCuentaDebeEstarCancelada()
        {
            Assert.IsNotNull(cuenta);
            Assert.IsTrue(cuenta.Cancelada);
        }

        [Then(@"debe producirse un error con el mensaje: ""(.*)""")]
        public void EntoncesDebeProducirseUnErrorConElMensaje(string mensaje)
        {
            Assert.IsNotNull(excepcion);
            Assert.AreEqual(mensaje, excepcion!.Message);
        }
    }
}
