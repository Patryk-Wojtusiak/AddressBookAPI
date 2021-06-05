using AddressBook.Applications.Boundary;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook.Application.Utilities
{
    public class ConsoleLoger : ILoger
    {

        public void Log(string message)
        {
            Console.WriteLine(System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")," ",message);
        }
    }
}
