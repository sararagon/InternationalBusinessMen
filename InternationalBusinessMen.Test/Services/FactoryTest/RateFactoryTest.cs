using System;
using InBuMenModels.Classes;
using InBuMenModels.Interfaces;
using InBuMenWebApi.Services.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InternationalBusinessMen.Test.Services.FactoryTest
{
    [TestClass]
    public class RateFactoryTest
    {
        private IRateFactory _factory;
        private IJsonRate _correctJsonRate;
        private IJsonRate _incorrectJsonRate;
        private IJsonRate _empityJsonRate;


        [TestInitialize]
        public void TestInicialize()
        {
            _factory = new RateFactory();
            _correctJsonRate = new JsonRate()
            {
                From = "EUR",
                To = "USD",
                Rate = "0.772"
            };
            _incorrectJsonRate = new JsonRate()
            {
                Rate = "0.0.1"
            };
            _empityJsonRate= new JsonRate();
        }

        [TestMethod]
        public void CorrectRateFactoryResult()
        {
            var rate = _factory.SaveRate(_correctJsonRate);
            Assert.rate.
        }
    }
}
