using System;
using System.Collections.Generic;
using System.Text;



namespace AddressBook.Applications.Boundary.Queries
{
    public interface IGetData
    {
        /// <summary>
        /// Gets last added Address in address book
        /// </summary>
        /// <returns>Latest address</returns>
        Model.Address GetLastAddress();
        /// <summary>
        /// Gets all addresses in address book
        /// </summary>
        /// <returns>list of all addresses</returns>
        List<Model.Address> GetAllAddresses();
        /// <summary>
        /// Get all addresses from city
        /// </summary>
        /// <param name="city">city from witch addresses will be taken</param>
        /// <returns>list of address</returns>
        List<Model.Address> GetAddressesByCity(string city);
    }
}
