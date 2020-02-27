using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using Antlr.Runtime;
using InBuMenCrossCutting.Exceptions;
using InBuMenModels.Classes;
using InBuMenWebApi.Services.Main;
using InBuMenWebApi.Services.Repository;

namespace InBuMenWebApi.Controllers
{
    public class ValuesController : ApiController
    {
        private IFromJsonRepositoryToJsonRepository _mainProgram;
        
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public OkNegotiatedContentResult<string> RateList()
        {
            try
            {
                string resultService = _mainProgram.MainService();
                return Ok(resultService);
            }
            catch (Exception ex)
            {
                throw new ValuesControlerException(ex);
            }

           
        }

       

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
