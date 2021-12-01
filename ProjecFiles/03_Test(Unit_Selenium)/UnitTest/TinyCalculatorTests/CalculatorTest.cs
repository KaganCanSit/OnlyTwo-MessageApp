using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TinyCalculator;

namespace TinyCalculatorTests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void CanInstantiateCalculator()
        {
            Calculator calc = new Calculator();
        }

        //Invalid Deðer Girilebiliyor Mu?
        [TestMethod]
        public void TestInvalidInput()
        {
            Calculator calc = new Calculator();
            try
            {
                int result = calc.Calculate("abcd");
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
        }

        //1+1 Girdisinde Sonuc 2 Deðerini Dönüyor Mu?
        [TestMethod]
        public void OnePlusOne()
        {
            Calculator calc = new Calculator();
            int result = calc.Calculate("1+1");
            Assert.AreEqual(2,result);
        }

        void DomSumTest(string input, int expected)
        {
            Calculator calc = new Calculator();
            int result = calc.Calculate(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TwoPlusTwo()
        {
            DomSumTest("2+2", 4);
        }

        [TestMethod]
        public void FourPlusEleven()
        {
            DomSumTest("4+11",15);
        }

        [TestMethod]
        public void TwoMinesOne()
        {
            DomSumTest("2-1", 1);
        }

        [TestMethod]
        public void FiveMinusTwo()
        {
            DomSumTest("5-2", 3);
        }

        [TestMethod]
        public void FiveTimesTwo()
        {
            DomSumTest("5*2", 10);
        }

        [TestMethod]
        public void EightDivideByTwo()
        {
            DomSumTest("8/2", 4);
        }

        //[TestMethod]
        //public void EightDividedByTwo()
        //{
        //    DomSumTest("8+2+3", 13);
        //}

    }
}
