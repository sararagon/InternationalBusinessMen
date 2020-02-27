using System.Web.Mvc;
using InBuMenModels.Classes;
using InBuMenModels.Interfaces;
using InBuMenWebApi.Services.Factory;
using InBuMenWebApi.Services.Log;
using InBuMenWebApi.Services.Main;
using InBuMenWebApi.Services.Repository;
using Unity;
using Unity.Mvc5;

namespace InBuMenWebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<ICurrency, Currency>();
            container.RegisterType<IJsonRate, JsonRate>();
            container.RegisterType<IJsonRateGroup, JsonRateGroup>();
            container.RegisterType<IJsonTransaction, JsonTransaction>();
            container.RegisterType<IJsonTransactionGroup, JsonTransactionGroup>();
            container.RegisterType<IRate, Rate>();
            container.RegisterType<ITransaction, Transaction>();
            container.RegisterType<IRepository<IJsonRate>, Repository<IJsonRate>>();
            container.RegisterType<IRepository<IJsonTransaction>, Repository<IJsonTransaction>>();
            container.RegisterSingleton<ILog, Log>();
            container.RegisterType<IRateFactory, RateFactory>();
            container.RegisterType<ITransactionFactory, TransactionFactory>();
            container.RegisterType<IRepository<Rate>, Repository<Rate>>();
            container.RegisterType<IRepository<Transaction>, Repository<Transaction>>();
            container.RegisterType<IRepository<Currency>, Repository<Currency>>();
            container.RegisterType<IFromJsonRepositoryToJsonRepository, FromJsonRepositoryToJsonRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}