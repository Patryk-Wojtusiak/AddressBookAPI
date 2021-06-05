using AddressBook.Applications.Boundary.Queries;
using AddressBook.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace AddressBook.Application.Queries
{
    public class GetDataFromFile : IGetData
    {
        static string _filePath = Path.Combine(AppContext.BaseDirectory, "Data", "AddressBookData.json");
        public List<Model.Address> GetAddressesByCity(string city)
        {
            string json = File.ReadAllText(_filePath);
            var addresses = JsonConvert.DeserializeObject<List<Address>>(json);
            var result = addresses.Where(x => x.City == city).ToList();
            return result;
        }

        public List<Model.Address> GetAllAddresses()
        {
            string json = File.ReadAllText(_filePath);
            var result = JsonConvert.DeserializeObject<List<Address>>(json);            
            return result;
        }

        public Model.Address GetLastAddress()
        {
            string json = File.ReadAllText(_filePath);
            var result = JsonConvert.DeserializeObject<List<Address>>(json).Last();
            return result;
        }
    }
}
