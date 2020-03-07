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

            System.Console.WriteLine("Choose Domain of problems to solve (only 1 at this moment!)\n1. Algorithms \n2.Data Structures (so far empty!)");
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
                    Menu.MainMenu();
                    break;

            }
        }

        public static void Algorithms()
        {
            System.Console.WriteLine("ALGORITHMS DOMAIN\nChoose Subbomain of problems to solve\n1. WarmUp \n2. Implementation \n3. Strings\n4. Sorting");
            int switchNo;
            switchNo = Convert.ToInt32(Console.ReadLine()) ;
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

            System.Console.WriteLine("DATA STRUCTURES DOMAIN\nNothing to do here press any key to go back to main menu!");
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
        }
        public static void Implementation()
        {
            System.Console.WriteLine("Implementation SUBDOMAIN\nchoose problem to solve/press any key to go back\n1. Grading studetns\n2. Apple nad orange\n3. Kangaroo\n4. Between two sets\n5. Breaking records\n6 Birthday\n7. Divisible sum pairs\n8. Migratory birds\n9. day of the programmer\n10 Bon appetit\n11 Sock merchant");
            int switchNo;
            switchNo = Convert.ToInt32(Console.ReadLine()) ;
            // Problems.simpleArraySum();
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
                default:
                    Menu.Algorithms();
                    break;
            }
        }
        public static void Strings()
        {
            System.Console.WriteLine("STRING SUBDOMAIN\nchoose problem to solve/press any key to go back\n1. Super reduced strings\n2. Camel case\n3. Password strength (minimum number)\n4. Two characters");
            int switchNo;
            switchNo = Convert.ToInt32(Console.ReadLine()) ;
            // Problems.simpleArraySum();
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
                default:
                    Menu.Algorithms();
                    break;
            }
        }

        public static void Sorting()
        {
            System.Console.WriteLine("SORTING SUBDOMAIN\nchoose problem to solve/press any key to go back\n1. Tutorial intro\n");
            int switchNo;
            switchNo = Convert.ToInt32(Console.ReadLine()) ;
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
        }
    }


}