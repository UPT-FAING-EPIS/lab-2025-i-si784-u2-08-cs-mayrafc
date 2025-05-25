using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Calculator.Domain.Tests.Steps
{
    [Binding]
    public sealed class CalculatorTests
    {
        private readonly ScenarioContext _scenarioContext;
        public Calculator Calculadora { get; set; }
        private int _operador01;
        private int _operador02;
        private int _resultado;

        public CalculatorTests(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            Calculadora = new Calculator();
        }

        [Given("El numero (.*)")]
        public void DadoElNumero(int operando01)
        {
            _operador01 = operando01;
        }

        [Given("el numero (.*)")]
        public void YElNumero(int operando02)
        {
            _operador02 = operando02;
        }

        [When("sumo")]
        public void CuandoSumo()
        {
            _resultado = Calculadora.Add(_operador01, _operador02);
        }

        [When("resto")]
        public void CuandoResto()
        {
            _resultado = Calculadora.Subtract(_operador01, _operador02);
        }

        [Then("el resultado es (.*)")]
        public void EntoncesElResultadoDeberiaSer(int resultado)
        {
            Assert.That(_resultado, Is.EqualTo(resultado));
        }
    }
}
