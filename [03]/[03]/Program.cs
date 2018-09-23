using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace _03_
{
    class Program
    {
        static int p1Point = 0;
        static int p2Point = 0;
        static int p1Set = 0;
        static int p2Set = 0;
        static int p1Game = 0;
        static int p2Game = 0;
        static string p1Opt = "";
        static string p2Opt = "";
        static string p1 = "";
        static string p2 = "";
        static int sum1 = 0;
        static int sum2 = 0;
        static string txtLogo = "H:/[03]/logo.txt";
        static string txtPic = "H:/[03]/pic.txt";
        static string txtWin = "H:/[03]/winner.txt";
        static void Main(string[] args)
        {
            Console.Title = "Tennis Refeere APP";
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            printTXT(txtPic);
            printTXT(txtLogo);
            bool x = true;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter Player One Name:\n");
            p1 = Console.ReadLine().Substring(0, 3);
            Console.WriteLine($"\n");
            Console.WriteLine("Enter Player Two Name:\n");
            p2 = Console.ReadLine().Substring(0, 3);
            Console.Clear();
            Console.WriteLine($"Player 1 Is:{p1}\n");
            Console.WriteLine($"Player 2 Is:{p2}\n");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"For Add Point To Each Player, Enter Her/His Number\n");
            while (x)
            {
                Console.WriteLine("Enter next Number:\n");
                int EnteredNum = Int32.Parse(Console.ReadLine());
                if (sum1 == 40)
                {
                    switch (EnteredNum)
                    {
                        case 1:
                            if (sum2 != 40)
                            {
                                p1Set += 1;
                                p1Point = 0;
                                p2Point = 0;
                                sum1 = 0;
                                sum2 = 0;
                                if ((p1Set - p2Set >= 2) && (p1Set + p2Set >= 4))
                                {
                                    p1Game += 1;
                                    p1Set = 0;
                                    p2Set = 0;
                                    if ((p1Game - p2Game >= 2) && (p1Game + p2Game >= 3))
                                    {
                                        p1Game = 0;
                                        p2Game = 0;
                                        Console.Clear();
                                        Console.WriteLine($"**** The Winner Is {p1} ****");
                                        Console.WriteLine($"\n");
                                        printTXT(txtWin);
                                        x = false;
                                    }
                                }
                            }
                            else
                            {
                                p1Opt = "AD";
                                adPoint();
                            }
                            break;

                        case 2:
                            if (sum2 != 40)
                            {
                                if (p2Point < 30)
                                {
                                    p2Point += 15;
                                    sum2 += 15;
                                }
                                else
                                {
                                    p2Point += 10;
                                    sum2 += 10;
                                }

                            }
                            else
                            {
                                p2Opt = "AD";
                                adPoint();
                            }
                            break;

                    }
                    Console.WriteLine($"**** {p1}: Point Is: {p1Point} ** Set Is: {p1Set} ** Game Is: {p1Game} ** {p1Opt} **** ");
                    Console.WriteLine($"**** {p2}: Point Is: {p2Point} ** Set Is: {p2Set} ** Game Is: {p2Game} ** {p2Opt} **** ");
                    Console.ReadKey();
                    Console.Clear();
                }
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                else if (sum2 == 40)
                {
                    switch (EnteredNum)
                    {
                        case 1:
                            if (sum1 != 40)
                            {
                                if (p1Point < 30)
                                {
                                    p1Point += 15;
                                    sum1 += 15;
                                }
                                else
                                {
                                    p1Point += 10;
                                    sum1 += 10;
                                }
                            }
                            else
                            {
                                p1Opt = "AD";
                                adPoint();
                            }

                            break;

                        case 2:
                            if (sum1 != 40)
                            {
                                p2Set += 1;
                                p1Point = 0;
                                p2Point = 0;
                                sum1 = 0;
                                sum2 = 0;
                                if ((p2Set - p1Set >= 2) && (p1Set + p2Set >= 4))
                                {
                                    p2Game += 1;
                                    p1Set = 0;
                                    p2Set = 0;
                                    if ((p2Game - p1Game >= 2) && (p1Game + p2Game >= 3))
                                    {
                                        p1Game = 0;
                                        p2Game = 0;
                                        Console.Clear();
                                        Console.WriteLine($"**** The Winner Is {p2} ****");
                                        Console.WriteLine($"\n");
                                        printTXT(txtWin);
                                        x = false;
                                    }

                                }
                            }
                            else
                            {
                                p2Opt = "AD";
                                adPoint();
                            }

                            break;
                    }
                    Console.WriteLine($"**** {p1}: Point Is: {p1Point} ** Set Is: {p1Set} ** Game Is: {p1Game} ** {p1Opt} ****");
                    Console.WriteLine($"**** {p2}: Point Is: {p2Point} ** Set Is: {p2Set} ** Game Is: {p2Game} ** {p2Opt} ****");
                    Console.ReadKey();
                    Console.Clear();
                }
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                else
                {
                    while ((EnteredNum == 1 && sum1 < 40) || (EnteredNum == 2 && sum2 < 40))
                    {
                        switch (EnteredNum)
                        {
                            case 1:
                                if (sum1 < 30)
                                {
                                    sum1 += 15;
                                }
                                else
                                {
                                    sum1 += 10;
                                }
                                p1Point = sum1;
                                EnteredNum = 0;
                                Console.WriteLine($"**** {p1}: Point Is: {p1Point} ** Set Is: {p1Set} ** Game Is: {p1Game} ** {p1Opt} ****");
                                Console.WriteLine($"**** {p2}: Point Is: {p2Point} ** Set Is: {p2Set} ** Game Is: {p2Game} ** {p2Opt} ****");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            case 2:
                                if (sum2 < 30)
                                {
                                    sum2 += 15;
                                }
                                else
                                {
                                    sum2 += 10;
                                }
                                p2Point = sum2;
                                EnteredNum = 0;
                                Console.WriteLine($"**** {p1}: Point Is: {p1Point} ** Set Is: {p1Set} ** Game Is: {p1Game} ** {p1Opt} ****");
                                Console.WriteLine($"**** {p2}: Point Is: {p2Point} ** Set Is: {p2Set} ** Game Is: {p2Game} ** {p2Opt} ****");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
                    }
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static void adPoint()
        {

            while (p1Opt == "AD" || p2Opt == "AD")
            {
                Console.Clear();
                Console.WriteLine("AD Point\n");
                Console.WriteLine($"{p1}: Point Is: {p1Point} ** Set Is: {p1Set} ** Game Is: {p1Game} ** {p1Opt} ****");
                Console.WriteLine($"{p2}: Point Is: {p2Point} ** Set Is: {p2Set} ** Game Is: {p2Game} ** {p2Opt} ****");
                Console.ReadKey();
                Console.WriteLine("Enter Number Of Player That Get Point:\n");
                int numP = Int32.Parse(Console.ReadLine());
                if (numP == 1 && p1Opt == "AD")
                {
                    p1Opt = "";
                    p1Set += 1;
                    p1Point = 0;
                    p2Point = 0;
                    sum1 = 0;
                    sum2 = 0;
                    if ((p1Set - p2Set >= 2) && (p1Set + p2Set >= 4))
                    {
                        p1Game += 1;
                        p1Set = 0;
                        p2Set = 0;
                        if ((p1Game - p2Game >= 2) && (p1Game + p2Game >= 3))
                        {
                            p1Game = 0;
                            p2Game = 0;
                            Console.Clear();
                            Console.WriteLine($"**** The Winner Is {p1} ****");
                        }
                    }

                }
                else if (numP == 2 && p2Opt == "AD")
                {
                    {
                        p2Opt = "";
                        p2Set += 1;
                        p1Point = 0;
                        p2Point = 0;
                        sum1 = 0;
                        sum2 = 0;
                        if ((p2Set - p1Set >= 2) && (p1Set + p2Set >= 4))
                        {
                            p2Game += 1;
                            p1Set = 0;
                            p2Set = 0;
                            if ((p2Game - p1Game >= 2) && (p1Game + p2Game >= 3))
                            {
                                p1Game = 0;
                                p2Game = 0;
                                Console.Clear();
                                Console.WriteLine($"**** The Winner Is {p2} ****");
                            }
                        }
                    }
                }
                else
                {
                    p1Opt = "";
                    p2Opt = "";
                }


            }
        }
        static void printTXT(string txtAdress)
        {
            using (StreamReader reader2 = File.OpenText(txtAdress))
            {
                string txtBuf = "";
                while ((txtBuf = reader2.ReadLine()) != null)
                {
                    Console.WriteLine(txtBuf);
                }
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}

