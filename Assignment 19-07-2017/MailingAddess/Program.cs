using System;
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
            Console.WriteLine("Enter City=");
            string City = Console.ReadLine();
            Console.WriteLine("Enter City=");
            string Street = Console.ReadLine();
            Console.WriteLine("Enter Street=");
            string pin = Console.ReadLine();
            Console.WriteLine("Enter pin=");
            string houseNumber = Console.ReadLine();
            Display show = new Display();
            show.MailingAddress(UserName, City, Street, pin, houseNumber);

        }
    }

    public class Display
    {
        public string MailingAddress(string UserName, string City, string Street, string pin, string houseNumber)
        {
            return (UserName +"\n"+ houseNumber + Street + City + "\nPIN=" + pin);
        }
    }

}
