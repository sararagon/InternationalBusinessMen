using System;
using InBuMenModels.Classes;
using InBuMenModels.Interfaces;
using InBuMenWebApi.Services.Factory;
using InBuMenWebApi.Services.Specification;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InternationalBusinessMen.Test.Services.FactoryTest
{
    [TestClass]
    public class TransactionFactoryTest
    {
        private ITransactionFactory _factory;
        private IJsonTransaction _correctJsonTransaction;
        private IJsonTransaction _incorrectJsonTransaction;
        private IJsonTransaction _emptyJsonTransaction;


        [TestInitialize]
        public void TestInicialize()
        {
            _factory = new TransactionFactory();
            _correctJsonTransaction = new JsonTransaction()
            {
                Amount = "10.00",
                Currency = "CAD",
                Sku = "A2001"
            };
            _incorrectJsonTransaction = new JsonTransaction()
            {
                Amount = "3.3.0",
                Currency = "e",
                Sku = ""
            };
            _emptyJsonTransaction = new JsonTransaction();
        }

        [TestMethod]
        public void CorrectRateFactoryResult()
        {
            var transaction = _factory.SaveTransaction(_correctJsonTransaction);
            Assert.IsInstanceOfType(transaction, typeof(Rate));
        }

        [global::Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void InorrectRateFactoryResult()
        {
            var transaction = _factory.SaveTransaction(_incorrectJsonTransaction);
            
        }

        [TestMethod]
        public void EmptyRateFactoryResult()
        {
            var transaction = _factory.SaveTransaction(_emptyJsonTransaction);
            Assert.IsNotInstanceOfType(transaction, typeof(Rate));
        }
    }
}
