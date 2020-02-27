using System;
using InBuMenWebApi.Services.Specification;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NMemory.Tables;

namespace InternationalBusinessMen.Test.Services.Specification
{
    [TestClass]
    public class CurrentSpecificationTest
    {
        private ICurrencySpecification _specification;
        private string _correctCurrency;
        private string _incorrectCurrency;

        [TestInitialize]
        public void TestInicialize()
        {
            _correctCurrency = "EUR";
            _incorrectCurrency = "EURO";
            _specification = new CurrencySpecification();
        }

        [TestMethod]
        public void IntroduceCorrectCurrency()
        {
            Assert.IsTrue(_specification.IsSatisfiedBy(_correctCurrency));
        }

        [TestMethod]
        public void IntroduceIncorrectCurrency()
        {
            Assert.IsFalse(_specification.IsSatisfiedBy(_incorrectCurrency));
        }

        [TestMethod]
        public void IntroduceNullCurrency()
        {
            Assert.IsFalse(_specification.IsSatisfiedBy(null));
        }

        [TestMethod]
        public void IntroduceEmptyCurrency()
        {
            Assert.IsFalse(_specification.IsSatisfiedBy(""));
        }
    }
}
