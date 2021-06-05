using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddressBook.Application.Utilities;
using AddressBook.Applications.Boundary.Queries;
using AddressBook.Model;
using Microsoft.AspNetCore.Mvc;

namespace AddressBookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressBookController : ControllerBase
    {
        private readonly IGetData _getData;
        private readonly ISetData _setData;
        private readonly ILoger _loger;

        [HttpGet("{city}")]
        public ActionResult<List<AddressBook.Model.AddressBook>> Get(string city)
        {  
            var result = _getData.GetAddressesByCity(city);
            _loger.Log($"requested addresses from {city} and got {result.Count} results");
            return result;
        }

        [HttpGet]
        public ActionResult<AddressBook.Model.AddressBook> Get()
        {
            var result = _getData.GetLastAddress();
            _loger.Log($"requested last address and send id={result.Id}");
            return result;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
