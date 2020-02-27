using System.Web.Mvc;
using InBuMenModels.Classes;
using InBuMenModels.Interfaces;
using Unity;
using Unity.Mvc5;
using WebApiInBuMen.Services.Repository;

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

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}