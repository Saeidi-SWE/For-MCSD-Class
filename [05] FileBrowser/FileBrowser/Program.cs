using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileBrowser
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            Console.WriteLine("Drivers:");
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < drives.Length; i++)
            {
                if (drives[i].IsReady)
                    Console.WriteLine($"{i + 1}.{drives[i]}");
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Enter Your Choice Number:\n");
            int choiceNumber = Int32.Parse(Console.ReadLine());
            Console.Clear();
            ///////////////////////////////////////////////////////////////////
            DirectoryInfo di = new DirectoryInfo($@"{drives[choiceNumber - 1]}");
            var subDirectories = di.GetDirectories();
            var files = di.GetFiles();
            Console.WriteLine(di);
            Console.WriteLine("Directories:");
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < subDirectories.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{subDirectories[i].FullName}");

            }
            Console.WriteLine($"\n");
            Console.WriteLine("Files:");
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine($"{i + subDirectories.Length + 1}.{files[i].FullName}\t{files[i].LastWriteTime}\n");
            }
            Console.WriteLine("\n");
            ////////////////////////////////////////////////////////////////////
            while (true)
            {            
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Enter Your Choice Number:\n");
                choiceNumber = Int32.Parse(Console.ReadLine());
                Console.Clear();
                if (choiceNumber - 1 < subDirectories.Length && choiceNumber - 1 >= 0)
                {
                    di = new DirectoryInfo($@"{subDirectories[choiceNumber - 1].FullName}");
                    subDirectories = di.GetDirectories();
                    files = di.GetFiles();
                    Console.WriteLine("Directories:");
                    Console.WriteLine("-----------------------------");
                    for (int i = 0; i < subDirectories.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}.{subDirectories[i].FullName}");

                    }
                    Console.WriteLine($"\n");
                    Console.WriteLine("Files:");
                    Console.WriteLine("-----------------------------");
                    for (int i = 0; i < files.Length; i++)
                    {
                        Console.WriteLine($"{i + subDirectories.Length + 1}.{files[i].FullName}\t{files[i].LastWriteTime}\n");
                    }
                    Console.WriteLine("\n");
                }
                else if ((choiceNumber >= (subDirectories.Length + 1)) && (choiceNumber <= (subDirectories.Length + files.Length)))
                {
                    Process.Start(di.GetFiles()[choiceNumber - subDirectories.Length-1].FullName);
                }
                else
                {
                    Console.WriteLine("Enter True Number:\n");
                }
 
            }



















            //while (true)
            //{
            //    Console.WriteLine("\n");
            //    Console.WriteLine("Enter Your Choice Number:\n");
            //    int choiceNumber2 = Int32.Parse(Console.ReadLine());
            //    DirectoryInfo di2 = new DirectoryInfo($@"{subDirectories[choiceNumber2 - 1]}");
            //    var subDirectories2 = di2.GetDirectories();
            //    var files2 = di2.GetFiles();
            //    Console.Clear();
            //    ///////////////////////////////////////////////////////////////
            //    Console.WriteLine("Directories:");
            //    Console.WriteLine("-----------------------------");
            //    for (int i = 0; i < subDirectories2.Length; i++)
            //    {
            //        Console.WriteLine($"{i + 1}.{subDirectories2[i].FullName}");

            //    }
            //    Console.WriteLine($"\n");
            //    Console.WriteLine("Files:");
            //    Console.WriteLine("-----------------------------");
            //    for (int i = 0; i < files2.Length; i++)
            //    {
            //        Console.WriteLine($"{i + 1}.{files2[i].FullName}\t{files2[i].LastWriteTime}");
            //    }
            //    Console.ReadKey();
            //}

            Console.ReadKey();

        }
    }
}
