using AddressBook.Application.Queries;
using AddressBook.Application.Utilities;
using AddressBook.Applications.Boundary.Queries;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AddressBook.Application
{
    public static class DependencyResolver
    {
        public static void AddAddressBookApplication(this IServiceCollection services)
        {
            services.AddTransient<IGetData, GetDataFromFile>();
            services.AddTransient<ISetData, SetDataToFile>();
            services.AddTransient<ILoger, ConsoleLoger>();            
        }
    }
}
