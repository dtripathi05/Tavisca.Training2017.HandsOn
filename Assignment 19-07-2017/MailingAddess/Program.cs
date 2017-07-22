using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingAddess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter User's Name=");
            string UserName = Console.ReadLine();
            Console.WriteLine("Enter House Number=");
            string houseNumber = Console.ReadLine();
            Console.WriteLine("Enter Street=");
            string Street = Console.ReadLine();
            Console.WriteLine("Enter City=");
            string City = Console.ReadLine();
            Console.WriteLine("Enter Pin=");
            string pin = Console.ReadLine();
            Display show = new Display();
            string address = show.MailingAddress(UserName, City, Street, pin, houseNumber);
            Console.WriteLine(address);
            Console.ReadKey();

        }
    }
}
