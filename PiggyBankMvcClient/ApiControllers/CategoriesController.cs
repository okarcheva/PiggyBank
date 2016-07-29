using PiggyBankCore.Domain;
using PiggyBankCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PiggyBankMvcClient.ApiControllers
{
    public class CategoriesController : ApiController
    {
        private readonly IRepository<Category> _repository;

        public CategoriesController()
        {
            _repository = new CategoryRepository();
        }

        // GET api/<controller>
        public IEnumerable<Category> Get()
        {
            return _repository.List;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}