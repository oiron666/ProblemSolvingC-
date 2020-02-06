using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace problemSolving
{
    public class Menu
    {
        public static void MainMenu()
        {

            System.Console.WriteLine("Choose Domain of problems to solve (only 1 at this moment!) 1. Algorithms \n2.Data Structures (so far empty!)");
            int switchNo;
            switchNo = Convert.ToInt32(Console.ReadLine()) ;

            switch (switchNo)
            {
                case 1:
                    Menu.Algorithms();
                    break;
                case 2:
                    Menu.DataStructures();
                    break;
                default:
                    break;

            }
        }

        public static void Algorithms()
        {
            System.Console.WriteLine("Choose Subbomain of problems to solve 1. WarmUp \n2. Implementation\n3. Strings");
            int switchNo;
            switchNo = Convert.ToInt32(Console.ReadLine()) ;
            // Problems.simpleArraySum();
            switch (switchNo)
            {
                case 1:
                    Menu.WarmUp();
                    break;
                case 2:
                    Menu.Strings();
                    break;
                default:
                    Menu.MainMenu();
                    break;
            }
        }

        public static void DataStructures()
        {

            System.Console.WriteLine("Nothing to do here press any key to go back to main menu!");
            int switchNo;
            switchNo = Convert.ToInt32(Console.ReadLine()) ;
            // Problems.simpleArraySum();
            switch (switchNo)
            {
                case 1:
                    Menu.MainMenu();
                    break;
                default:
                    Menu.MainMenu();
                    break;

            }
        }

        public static void WarmUp()
        {
            System.Console.WriteLine("STRING SUBDOMAIN\nchoose problem to solve or any other key to go back \n1. simpleArraySum \n2. compareTriplets \n3. aVeryBigsum \n4. Diagonal difference \n5. Plus Minus\n6. SPtaircase \n7. miniMaxPlus \n8. Birthday cake candles\n9. timeConversion");
            int switchNo;
            switchNo = Convert.ToInt32(Console.ReadLine()) ;
            // Problems.simpleArraySum();
            switch (switchNo)
            {
                case 1:
                    Problems.simpleArraySum();
                    break;
                case 2:
                    Problems.compareTriplets();
                    break;
                case 3:
                    Problems.aVeryBigsum();
                    break;
                case 4:
                    Problems.diagonalDifference();
                    break;
                case 5:
                    Problems.plusMinus();
                    break;
                case 6:
                    Problems.staircase();
                    break;
                case 7:
                    Problems.miniMaxSum();
                    break;
                case 8:
                    Problems.birthdayCakeCandles();
                    break;
                case 9:
                    Problems.timeConversion();
                    break;
                default:
                    Menu.Algorithms();
                    break;
            }
        }

        public static void Strings()
        {
            System.Console.WriteLine("STRING SUBDOMAIN\nchoose problem to solve/press any key to go back  ");
            int switchNo;
            switchNo = Convert.ToInt32(Console.ReadLine()) ;
            // Problems.simpleArraySum();
            switch (switchNo)
            {
                case 1:
                    Menu.Algorithms();
                    break;
                    default:
                    Menu.Algorithms();
                    break;

            }
        }
    }


}