using System;
using Lyceum.Domain;

namespace Lyceum.ConsoleClinet
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var customer = new Customer(
                    new CustomerId(2),
                    new FirstName(@"Wahab"),
                    new LastName(@"Syed"),
                    new EmailAddress(@"wahab.email"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
