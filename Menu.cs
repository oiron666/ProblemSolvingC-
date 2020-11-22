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
            Console.Clear();
            System.Console.WriteLine("Choose Domain of problems to solve (only 1 at this moment!)\n1. Algorithms \n2. Data Structures (so far empty!)");
            string switchValue = Console.ReadLine();
            int switchNo = CheckCorrectSwitchNumber(switchValue);
            switch (switchNo)
            {
                case 1:
                    Menu.Algorithms();
                    break;
                case 2:
                    Menu.DataStructures();
                    break;
                default:
                    Menu.MainMenu();
                    break;
            }
        }

        public static void Algorithms()
        {
            Console.Clear();

            System.Console.WriteLine("ALGORITHMS DOMAIN\nChoose Subbomain of problems to solve\n1. WarmUp \n2. Implementation \n3. Strings\n4. Sorting");
            
            string switchValue = Console.ReadLine();
            int switchNo = CheckCorrectSwitchNumber(switchValue);

            // Problems.simpleArraySum();
            switch (switchNo)
            {
                case 1:
                    Menu.WarmUp();
                    break;
                 case 2:
                    Menu.Implementation();
                    break;                   
                case 3:
                    Menu.Strings();
                    break;
                case 4:
                    Menu.Sorting();
                    break;
                default:
                    Menu.MainMenu();
                    break;
            }
        }

        public static void DataStructures()
        {
            Console.Clear();

            System.Console.WriteLine("DATA STRUCTURES DOMAIN\nNothing to do here press any key to go back to main menu!");
            string switchValue = Console.ReadLine();

            int switchNo = CheckCorrectSwitchNumber(switchValue);
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
            Console.Clear();

            System.Console.WriteLine("WARM UP SUBDOMAIN\nchoose problem to solve or any other key to go back \n1. simpleArraySum \n2. compareTriplets \n3. aVeryBigsum \n4. Diagonal difference \n5. Plus Minus\n6. SPtaircase \n7. miniMaxPlus \n8. Birthday cake candles\n9. timeConversion");
           
            string switchValue = Console.ReadLine();

            int switchNo = CheckCorrectSwitchNumber(switchValue);

            switch (switchNo)
            {
                case 1:
                    WarmUpProblems.simpleArraySum();
                    break;
                case 2:
                    WarmUpProblems.compareTriplets();
                    break;
                case 3:
                    WarmUpProblems.aVeryBigsum();
                    break;
                case 4:
                    WarmUpProblems.diagonalDifference();
                    break;
                case 5:
                    WarmUpProblems.plusMinus();
                    break;
                case 6:
                    WarmUpProblems.staircase();
                    break;
                case 7:
                    WarmUpProblems.miniMaxSum();
                    break;
                case 8:
                    WarmUpProblems.birthdayCakeCandles();
                    break;
                case 9:
                    WarmUpProblems.timeConversion();
                    break;
                default:
                    Menu.Algorithms();
                    break;
            }
            MainMenu();
        }
        public static void Implementation()
        {
            Console.Clear();
            System.Console.WriteLine("Implementation SUBDOMAIN\n" +
                "choose problem to solve/press any key to go back\n" +
                "1. Grading studetns\n" +
                "2. Apple nad orange\n" +
                "3. Kangaroo\n" +
                "4. Between two sets\n" +
                "5. Breaking records\n" +
                "6 Birthday\n" +
                "7. Divisible sum pairs\n" +
                "8. Migratory birds\n" +
                "9. day of the programmer\n" +
                "10 Bon appetit\n" +
                "11. Sock merchant\n" +
                "12. Page count \n" +
                "13. Electronic shop");

            string switchValue = Console.ReadLine();

            int switchNo = CheckCorrectSwitchNumber(switchValue);

            switch (switchNo)
            {
                case 1:
                    ImplementationProblems.gradingStudents();
                    break;
                case 2:
                    ImplementationProblems.countApplesAndOranges();
                    break;
                case 3:
                    ImplementationProblems.kangaroo();
                    break;
                case 4:
                    ImplementationProblems.betweenTwoSets();
                    break;
                case 5:
                    ImplementationProblems.breakingRecords();
                    break;
                case 6:
                    ImplementationProblems.birthday();
                    break;
                case 7:
                    ImplementationProblems.divisibleSumPairs();
                    break;
                case 8:
                    ImplementationProblems.migratoryBirds();
                    break; 
                case 9:
                    ImplementationProblems.dayOfProgrammer();
                    break;
                case 10:
                    ImplementationProblems.bonAppetit();
                    break; 
                case 11:
                    ImplementationProblems.sockMerchant();
                    break;   
                case 12:
                    ImplementationProblems.pageCount();
                    break;
                case 13:
                    ImplementationProblems.electronicShop();
                    break;
                default:
                    Menu.Algorithms();
                    break;
            }
            MainMenu();
        }
        public static void Strings()
        {
            Console.Clear();

            System.Console.WriteLine("STRING SUBDOMAIN\nchoose problem to solve/press any key to go back\n1. Super reduced strings\n2. Camel case\n3. Password strength (minimum number)\n4. Two characters\n5. Cesear cipher");
            
            string switchValue = Console.ReadLine();
            int switchNo = CheckCorrectSwitchNumber(switchValue);

            switch (switchNo)
            {
                case 1:
                    StringProblems.reducedStrings();
                    break;
                case 2:
                    StringProblems.camelcase();
                    break;
                case 3:
                    StringProblems.minimumNumber();
                    break;
                case 4:
                    StringProblems.alternate();
                    break;
                case 5:
                    StringProblems.caesarCipher();
                    break;
                default:
                    Menu.Algorithms();
                    break;
            }
            MainMenu();
        }

        public static void Sorting()
        {
            Console.Clear();

            System.Console.WriteLine("SORTING SUBDOMAIN\nchoose problem to solve/press any key to go back\n1. Tutorial intro\n");
            string switchValue = Console.ReadLine();

            int switchNo = CheckCorrectSwitchNumber(switchValue);
            // Problems.simpleArraySum();
            switch (switchNo)
            {
                case 1:
                    SortingProblems.introTutorial();
                    break;
                default:
                    Menu.Algorithms();
                    break;
            }
            MainMenu();
        }

        public static int CheckCorrectSwitchNumber(string switchValue)
        {
            int switchNumber = 0;
            try
            {
                switchNumber = Convert.ToInt32(switchValue);
            }
            catch (Exception)
            {
                System.Console.WriteLine("\nWrong value. Write a number\n");
            }

            return switchNumber;
        }
    }


}