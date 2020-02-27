using System.Collections.Generic;
using InBuMenModels.Interfaces;
using InBuMenWebApi.Services.Factory;
using InBuMenWebApi.Services.Reading;
using InBuMenWebApi.Services.Repository;
using Newtonsoft.Json;

namespace InBuMenWebApi.Services.Main
{
    public class FromJsonRepositoryToJsonRepository : IFromJsonRepositoryToJsonRepository
    {
        
        private IRateFactory _rateFactory;
        private IRepository<IJsonRate>_repository;
        private IRateApiReader _rateApiReader;

        public string MainService()
        {
            var jsonData = _rateApiReader.ReadRates();
            foreach (var jsonRate in jsonData.Rates)
            {
                _repository.Insert(jsonRate);
            }
            
            var goodDates = new List<IRate>();
            foreach (var rate in _repository.GetAll())
            {
                goodDates.Add (_rateFactory.SaveRate(rate));
            }

            string json = "";

            foreach (var element in goodDates)
            {
                json += JsonConvert.SerializeObject(element);

            }

            return json;
        }
    }
}