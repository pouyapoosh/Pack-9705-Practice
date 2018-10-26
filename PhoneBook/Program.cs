using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public void Add()
        {
            using (StreamWriter sw = new StreamWriter(@"S:\c#\Pack-9705-Practis\PhoneBook\TextFile1.txt"))
            {
                Console.WriteLine("Enter First Name:");
                sw.Write(Console.ReadLine());
                Console.WriteLine("Enter Last Name:");
                sw.Write(Console.ReadLine() + ',');
                Console.WriteLine("Enter PhoneNumber:");
                sw.WriteLine(Console.ReadLine());

            }
        }
    }
}
