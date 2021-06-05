using AddressBook.Applications.Boundary.Queries;
using AddressBook.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBook.Application.Queries
{
    public class SetDataToFile : ISetData
    {
        static string _filePath = Path.Combine(AppContext.BaseDirectory, "Data", "AddressBookData.json");
        public void AddNewAddress(Address address)
        {
            string json;
            if (File.Exists(_filePath))
            {
                json = File.ReadAllText(_filePath);
                var addresses = JsonConvert.DeserializeObject<List<Address>>(json);
                addresses.Add(address);
                json = JsonConvert.SerializeObject(addresses);
            }
            else
                json = JsonConvert.SerializeObject(new List<Address> { address });
            
            File.AppendAllText(_filePath, json);
                        
                
        }
        public void AddNewAddresses(List<Address> addresses)
        {
            string json;
            if (File.Exists(_filePath))
            { 
                json = File.ReadAllText(_filePath);
                addresses.AddRange(JsonConvert.DeserializeObject<List<Model.Address>>(json));            
            }
            json = JsonConvert.SerializeObject(addresses);
            File.AppendAllText(_filePath, json);
        }

        public void UpdateAddress(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
