using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            string sum1 = "";
            string sum2 = "";
            string[,] foodlist;
            foodlist = new string[3, 30];
            int recipenum = 0;
            int ingrediantnum = 0;
            int ingrediantnum2 = 0;
            var exit = false;
            while (exit != true)
            {
                Console.WriteLine("Please Select Your Option:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("*********************************************************************");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("1.Recipe List\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("2.Add Recipe\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("3.Edit Recipe\n");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("4.Remove Recipe\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("5.EXIT");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("*********************************************************************");
                Console.ForegroundColor = ConsoleColor.White;
                int si = Int32.Parse(Console.ReadLine());
                Console.Beep();
                while (si > 5 || si < 1)
                {
                    Console.WriteLine("Please Enter True Option:");
                    si = Int32.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Selected Item: {si}");
                Console.ReadKey();
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                switch (si)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Recipe List:\n");
                        if (recipenum == 0)
                            Console.WriteLine("List Is Empty, Please Add Recipe First");
                        else
                        {
                            for (int i = 0; i < recipenum; i++)
                                if (foodlist[0,i] != "")
                                {
                                    Console.WriteLine($"Recipe Name: {foodlist[0, i]}" + $"  That Have {foodlist[1, i]}Ingrediant: {foodlist[2, i]}  \n");
                                }

                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    case 2:
                        //Console.WriteLine("2");
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Add Recipe:");
                        Console.WriteLine("*********************************************************************");
                        Console.WriteLine("How many Recipe You Want To Add?\n");
                        recipenum = Int32.Parse(Console.ReadLine());
                        for (int i = 0; i < recipenum; i++)
                        {
                            Console.WriteLine($"Name Of Recipe {i + 1}:\n");
                            string name1 = Console.ReadLine();
                            foodlist[0, i] = name1;
                            Console.Beep();
                            Console.WriteLine("How Many Ingrediant ?\n");
                            ingrediantnum = Int32.Parse(Console.ReadLine());
                            foodlist[1, i] = Convert.ToString(ingrediantnum);
                            Console.Beep();
                            Console.WriteLine($"Number Of Ingrediant is {ingrediantnum}\n");
                            string[] tes;
                            tes = new string[ingrediantnum];
                            sum1 = "";
                            for (int j = 0; j < ingrediantnum; j++)
                            {
                                Console.WriteLine($"Please Enter Name Of Ingrediant {j + 1}: \n");
                                string a = Console.ReadLine();
                                Console.WriteLine($"Please Enter Ingrediant {j + 1} Weight In Gram: \n");
                                string b = Console.ReadLine();
                                tes[j] = (a + " " + b + "g");
                                sum1 += tes[j] + ",";
                                Console.Clear();
                            }
                            foodlist[2, i] = sum1;
                            Console.Clear();
                        }
                        Console.Clear();
                        break;
                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Edit Recipe List:\n");
                        if (recipenum == 0)
                        {
                            Console.WriteLine("List Is Empty, Please Add Recipe First");
                            Console.Clear();
                        }
                        else
                        {
                            for (int i = 0; i < recipenum; i++)
                            {
                                Console.WriteLine($"{i + 1}.Recipe Name: {foodlist[0, i]}\n");
                            }
                            Console.WriteLine("Type Number Of Recipe That You Want to Edit:\n");
                            int RID2 = Int32.Parse(Console.ReadLine());
                            foodlist[0, (RID2 - 1)] = "";
                            foodlist[1, (RID2 - 1)] = "";
                            foodlist[2, (RID2 - 1)] = "";
                            Console.WriteLine("Enter New Name:");
                            string name2 = Console.ReadLine();
                            foodlist[0, (RID2 - 1)] = name2;
                            Console.Beep();
                            Console.WriteLine("How Many Ingrediant ?\n");
                            ingrediantnum2 = Int32.Parse(Console.ReadLine());
                            foodlist[1, (RID2 - 1)] = Convert.ToString(ingrediantnum2);
                            Console.Beep();
                            Console.WriteLine($"Number Of Ingrediant is {ingrediantnum2}\n");
                            string[] tes2;
                            tes2 = new string[ingrediantnum2];
                            for (int f = 0; f < ingrediantnum2; f++)
                            {
                                Console.WriteLine($"Please Enter Name Of Ingrediant {f + 1}: \n");
                                string c = Console.ReadLine();
                                Console.WriteLine($"Please Enter Ingrediant {f + 1} Weight In Gram: \n");
                                string d = Console.ReadLine();
                                tes2[f] = (c + " " + d + "g");
                                Console.Clear();
                            }
                            for (int z = 0; z < tes2.Length; z++)
                            {
                                sum2 += tes2[z] + ",";
                            }
                            foodlist[2, (RID2 - 1)] = sum2;
                        }
                        break;

                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Delete From Recipe List:\n");
                        if (recipenum == 0)
                        {
                            Console.WriteLine("List Is Empty, Please Add Recipe First");
                            Console.Clear();
                        }
                        else
                        {
                            for (int i = 0; i < recipenum; i++)
                            {
                                Console.WriteLine($"{i + 1}.Recipe Name: {foodlist[0, i]}\n");
                            }
                            Console.WriteLine("Type Number Of Recipe That You Want to Remove:\n");
                            int RID = Int32.Parse(Console.ReadLine());
                            for (int i = 0; i < 3; i++)
                            {
                                foodlist[i, (RID - 1)] = "";
                            }

                            for (int t = 0; t < 29; t++)
                            {
                                var w = foodlist[0, t];
                                var s = foodlist[1, t];
                                var x = foodlist[2, t];
                                if (w == s && s == x)
                                {
                                    foodlist[0, t] = foodlist[0, t + 1];
                                    foodlist[0, t + 1] = "";
                                    foodlist[1, t] = foodlist[1, t + 1];
                                    foodlist[1, t + 1] = "";
                                    foodlist[2, t] = foodlist[2, t + 1];
                                    foodlist[2, t + 1] = "";
                                }
                            }
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    case 5:
                        Console.WriteLine("*********************************************************************");
                        Console.WriteLine("Tanx");
                        exit = true;
                        break;
                }
                Console.ReadKey();
            }
            Console.ReadKey();
        }
        //catch
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("**** Surry For This Erro, Please Restart The Program ****");
        //    Console.ReadKey();
        //}
        //}
    }
}
