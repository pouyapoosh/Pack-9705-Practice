using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowSubDrives(ShowDrives());
            Console.ReadKey();
        }
        static string ShowDrives()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            for (int i = 0; i < drives.Length; i++)
            {
                if (drives[i].IsReady)
                {
                    Console.WriteLine($"{i + 1}.{drives[i].Name} ({drives[i].VolumeLabel}) ");
                }
                else
                    Console.WriteLine($"{i + 1}.{drives[i].Name} ({drives[i].DriveType})");
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("choose the drive number:");
            while (true)
            {
                int ChoosenNumber = int.Parse(Console.ReadLine()) - 1;
                if (ChoosenNumber < drives.Length)
                {
                    return drives[ChoosenNumber].Name;
                }
                else
                {
                    Console.WriteLine("Invalid Number Choose Another One:");
                }
            }
        }
        static void ShowSubDrives(string a)
        {
            Console.Clear();
            DirectoryInfo di = new DirectoryInfo($"{a}");
            DirectoryInfo[] SubDirectory = di.GetDirectories();
            for (int i = 0; i < SubDirectory.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{SubDirectory[i].Name}");
            }
            FileInfo[] fi = di.GetFiles();
            for (int i = SubDirectory.Length, j = 0; i < SubDirectory.Length + fi.Length; i++, j++)
            {
                Console.WriteLine($"{i + 1}.{fi[j].Name} [file]");
            }
            Console.WriteLine((SubDirectory.Length + fi.Length + 1) + ".back");
            Console.WriteLine("----------------------------");
            Console.WriteLine("choose the file or folder number for start or openning :");
            while (true)
            {
                int ChoosenNumber = int.Parse(Console.ReadLine()) - 1;
                if (ChoosenNumber < SubDirectory.Length)
                {
                    ShowSubDrives(SubDirectory[ChoosenNumber].FullName);
                }
                else if (ChoosenNumber >= SubDirectory.Length && ChoosenNumber < SubDirectory.Length + fi.Length)
                {
                    int x = (ChoosenNumber - SubDirectory.Length);
                    var y = fi[x].DirectoryName;
                    Process.Start($"{y}/{fi[x].Name}");
                }
                //else if (ChoosenNumber == SubDirectory.Length + fi.Length)
                //{
                //    ShowSubDrives($"{SubDirectory[ChoosenNumber - 2].Parent}");
                //}
                else
                {
                    Console.WriteLine("Invalid Number Choose Another One:");
                }
            }
        }
    }
}
