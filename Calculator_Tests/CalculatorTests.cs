using System;
using System.Xml.Schema;
using Xunit;

namespace Calculator_Tests
{
    public class CalculatorTests
    {
        [Fact(DisplayName = "Test der Addition")]
        public void TestAddition()
        {
            Calculator.models.Calculator calc = new Calculator.models.Calculator();
            decimal result = calc.Calculate(2.5m, 4m, Calculator.models.CalculationType.ADDITION);
            Assert.Equal(6.5m, result);
        }

        [Fact(DisplayName = "Test der Subtracion")]
        public void TestSubtraction()
        {
            Calculator.models.Calculator calc = new Calculator.models.Calculator();
            decimal result = calc.Calculate(2.5m, 4m, Calculator.models.CalculationType.SUBTRACTION);
            Assert.Equal(-1.5m, result);
        }

        [Fact(DisplayName = "Test der Multiplication")]
        public void TestMultiplication()
        {
            Calculator.models.Calculator calc = new Calculator.models.Calculator();
            decimal result = calc.Calculate(2.5m, 4m, Calculator.models.CalculationType.MULTIPLICATION);
            Assert.Equal(10.0m, result);
        }

        [Fact(DisplayName = "Test der Division")]
        public void TestDivision()
        {
            Calculator.models.Calculator calc = new Calculator.models.Calculator();
            decimal result = calc.Calculate(2.5m, 4m, Calculator.models.CalculationType.DIVISTION);
            Assert.Equal(0.625m, result);
        }

        [Fact(DisplayName = "Test der Division durch null")]
        public void TestDivisionZero()
        {
            Calculator.models.Calculator calc = new Calculator.models.Calculator();
            decimal result = calc.Calculate(2.5m, 0m, Calculator.models.CalculationType.DIVISTION);

        }
    }
}