using System;

namespace AddressBook.Model
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string PostalCode { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
