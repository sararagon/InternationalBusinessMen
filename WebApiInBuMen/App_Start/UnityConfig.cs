using System.Web.Mvc;
using InBuMenModels.Classes;
using InBuMenModels.Interfaces;
using Unity;
using Unity.Mvc5;

namespace WebApiInBuMen
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<ICurrency, Currency>();
            container.RegisterType<IJsonRate, JsonRate>();
            container.RegisterType<IJsonTransaction, JsonTransaction>();
            container.RegisterType<IJsonTransactionGroup, JsonTransactionGroup>();
            container.RegisterType<IRate, Rate>();
            container.RegisterType<ITransaction, Transaction>();
            container.RegisterType<IJsonRateGroup, JsonRateGroup>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}