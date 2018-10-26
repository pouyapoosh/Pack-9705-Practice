using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                //^\d[0 - 1]/ ((0\d[0 - 6] / (\d[0 - 2]\d[1 - 9] | 30 | 31))| (0\d[7 - 9] / (\d[0 - 2]\d[1 - 9] | 30))| (1\d[0 - 2] / (\d[0 - 2]\d[1 - 9] | 30)))$
            {
                Console.Clear();
                Console.Write("Pattern: ");
               var pattern = Console.ReadLine(); ;
                if (pattern == "exit")
                    break;
                Regex re = new Regex(pattern);
                while (true)
                {
                    Console.Write("\nText:");
                    var text = Console.ReadLine();
                    if (text == "exit")
                        break;
                    var isMatch = re.IsMatch(text);
                    if (isMatch)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Match!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Not Match!");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
