using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punishment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] student = new string[1];
            string[] punishmentlist = new string[1];
            var exit = false;
            while (exit != true)
            {
                Console.Title = "Punishment Program";
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("1.Add To Student List:\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("2.Add To Punishment List:\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("3.GOOOO\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("4.Exit\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("********************************************");
                Console.WriteLine("Please Type Your Choice Number:\n");
                int menuNumber = Int32.Parse(Console.ReadLine());
                Console.Beep();
                /////////////////////////////////////////////////////////////////////////
                while (menuNumber < 1 || menuNumber > 4)
                {
                    Console.WriteLine("Please Enter True Option:");
                    menuNumber = Int32.Parse(Console.ReadLine());
                }

                Console.ReadKey();
                /////////////////////////////////////////////////////////////////////////
                switch (menuNumber)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Enter First Name:\n(For Return To Menu Type: finish)\n");
                        string input = Console.ReadLine();
                        student[0] = input;
                        while (input != "finish")
                        {
                            Console.Clear();
                            for (int i = 0; i < student.Length; i++)
                            {
                                Console.WriteLine(student[i]);
                            }

                            Console.WriteLine("Enter Name To Add:\n(For Return To Menu Type: finish)\n");
                            input = Console.ReadLine();
                            if (input.ToLower() != "finish" && input != "")
                            {
                                AddToArray(ref student, input);
                            }
                            else
                            {
                                input = "finish";
                            }
                        }

                        Console.Clear();
                        for (int i = 0; i < student.Length; i++)
                        {
                            Console.WriteLine(student[i]);
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    /////////////////////////////////////////////////////////////////////////
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter First Punishment:\n(For Return To Menu Type: finish)\n");
                        string input2 = Console.ReadLine();
                        punishmentlist[0] = input2;
                        while (input2 != "finish")
                        {
                            Console.Clear();
                            for (int i = 0; i < punishmentlist.Length; i++)
                            {
                                Console.WriteLine(punishmentlist[i]);
                            }

                            Console.WriteLine("Enter Name To Add:\n(For Return To Menu Type: finish)\n");
                            input2 = Console.ReadLine();
                            if (input2.ToLower() != "finish" && input2 != "")
                            {
                                AddToArray(ref punishmentlist, input2);
                            }
                            else
                            {
                                input2 = "finish";
                            }
                        }

                        Console.Clear();
                        for (int i = 0; i < punishmentlist.Length; i++)
                        {
                            Console.WriteLine(punishmentlist[i]);
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    /////////////////////////////////////////////////////////////////////////
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Green;
                        if (student.Length < 2)
                            Console.WriteLine("Student List Is Empty, Please Add List First");
                        else if (punishmentlist.Length < 2)
                        {
                            Console.WriteLine("Punishment List Is Empty, Please Add List First");
                        }
                        else
                        {
                            Console.WriteLine($"Unfortunately Miserable Student Is ** {ReturnRandomItem(student)} ** And his/her Punishment Is ** {ReturnRandomItem(punishmentlist)} ** :'(");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    /////////////////////////////////////////////////////////////////////////
                    case 4:
                        Console.WriteLine("Tanx ********************************************");
                        Console.WriteLine("");
                        exit = true;
                        break;
                }

            }
        }

        static void AddToArray(ref string[] names, string newName)
        {
            var newArray = new string[names.Length + 1];
            for (int i = 0; i < names.Length; i++)
            {
                newArray[i] = names[i];
            }
            newArray[newArray.Length - 1] = newName;
            names = newArray;
        }
        static string ReturnRandomItem(string[] inputList)
        {
            Random newRandom = new Random();
            int itemIndex = newRandom.Next(0, inputList.Length - 1);
            string itemOfList = inputList[itemIndex];
            return itemOfList;
        }
    }
}