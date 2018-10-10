using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
                {
                    new Student() { Name = "Ross", Family = "Geller", Average = 80 },
                    new Student() { Name = "Chandler", Family = "Bing", Average = 70 },
                    new Student() { Name = "Monica", Family = "Geller", Average = 90 }
                };

            Array.Sort(students);
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

            Console.ReadKey();
        }
    }
}
