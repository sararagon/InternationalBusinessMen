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
        private string CorrectCurrency;
        private string IncorrectCurrency;

        [TestInitialize]
        public void TestInicialize()
        {
            CorrectCurrency = "EUR";
            IncorrectCurrency = "EURO";
            _specification = new CurrencySpecification();
        }

        [TestMethod]
        public void IntroduceCorrectCurrency()
        {
            Assert.IsTrue(_specification.IsSatisfiedBy(CorrectCurrency));
        }

        [TestMethod]
        public void IntroduceIncorrectCurrency()
        {
            Assert.IsFalse(_specification.IsSatisfiedBy(IncorrectCurrency));
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
