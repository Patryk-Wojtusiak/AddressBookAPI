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
        public ActionResult<List<Address>> Get(string city)
        {  
            var result = _getData.GetAddressesByCity(city);
            _loger.Log($"requested addresses from {city} and got {result.Count} results");
            if(result!=null)
            return Ok(result);
            return NotFound($"No addresses from {city}");
        }
        [HttpGet]
        public ActionResult<Address> Get()
        {
            var result = _getData.GetLastAddress();
            _loger.Log($"requested last address and send id={result.Id}");
            if (result != null)
                return Ok(result);
            return NotFound($"No addresses in address book");
        }
        
        [HttpPost]
        public void Post([FromBody] Address address)
        {
            _setData.AddNewAddress(address);
            _loger.Log("new address added");
        }

       

    }
}
