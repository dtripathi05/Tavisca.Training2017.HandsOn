using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student Name=");
            string StudentName = Console.ReadLine();
            Console.WriteLine("Enter Roll Number=");
            string RollNumber = Console.ReadLine();
            Console.WriteLine("Enter Age=");
            string Age = Console.ReadLine();
            Console.WriteLine("Enter Class=");
            string Class = Console.ReadLine();
            Console.WriteLine("Enter University Name=");
            string UniversityName = Console.ReadLine();
            Display show = new Display();
            string address = show.MailingAddress(StudentName, RollNumber, Age, Class, UniversityName);
            Console.WriteLine(address);
            Console.ReadKey();
        }
    }
    public class Display
    {
        public string MailingAddress(string StudentName, string RollNumber, string Age, string Class, string UniversityName)
        {
            return (StudentName+"\n"+Age+"\n"+Class+"\n"+RollNumber+"\n"+UniversityName);
        }

    }
    
}
