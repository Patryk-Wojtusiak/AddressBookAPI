using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook.Applications.Boundary.Queries
{
    public interface ISetData
    {
        /// <summary>
        /// Add new address to address book
        /// </summary>
        /// <param name="address">address to add</param>
        void AddNewAddress(Model.AddressBook address);
        /// <summary>
        /// Add sevral addresses to the address book
        /// </summary>
        /// <param name="addresses">list of addresses to add</param>
        void AddNewAddresses(List<Model.AddressBook> addresses);
        /// <summary>
        /// Update an address
        /// </summary>
        /// <param name="address">Address to update (need to have correct id field)</param>
        void UpdateAddress(Model.AddressBook address);
    }
}
