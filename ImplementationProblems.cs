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
    public class ImplementationProblems
    {
        public static void gradingStudents()
        {

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = ImplementationSolutions.gradingStudents(grades);
            System.Console.WriteLine(String.Join("\n", result));
        }


        public static void countApplesAndOranges()
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));
            ImplementationSolutions.countApplesAndOranges(s, t, a, b, apples, oranges);
        }

        public static void kangaroo()
        {
            string[] x1V1X2V2 = Console.ReadLine().Split(' ');

            int x1 = Convert.ToInt32(x1V1X2V2[0]);

            int v1 = Convert.ToInt32(x1V1X2V2[1]);

            int x2 = Convert.ToInt32(x1V1X2V2[2]);

            int v2 = Convert.ToInt32(x1V1X2V2[3]);

            string result = ImplementationSolutions.kangaroo(x1, v1, x2, v2);

            System.Console.WriteLine(result);
        }

        public static void betweenTwoSets()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            int total = ImplementationSolutions.betweenTwoSets(arr, brr);

            System.Console.WriteLine(total);
        }

        public static void breakingRecords()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
            int[] result = ImplementationSolutions.breakingRecords(scores);
            System.Console.WriteLine(string.Join(" ", result));
        }

        public static void birthday()
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();
            string[] dm = Console.ReadLine().TrimEnd().Split(' ');
            int d = Convert.ToInt32(dm[0]);
            int m = Convert.ToInt32(dm[1]);
            int result = ImplementationSolutions.birthday(s, d, m);
            System.Console.WriteLine(result);
        }

        public static void divisibleSumPairs()
        {
            string[] nk = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = ImplementationSolutions.divisibleSumPairs(n, k, ar);
            System.Console.WriteLine(result);

        }

        public static void migratoryBirds()
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = ImplementationSolutions.migratoryBirds(arr);

            System.Console.WriteLine(result);

        }


        public static void dayOfProgrammer()
        {

            int year = Convert.ToInt32(Console.ReadLine().Trim());

            string result = ImplementationSolutions.dayOfProgrammer(year);

            System.Console.WriteLine(result);

        }

        public static void bonAppetit()
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            ImplementationSolutions.bonAppetit(bill, k, b);


        }
        public static void sockMerchant()
        {


            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = ImplementationSolutions.sockMerchant(n, ar);

            Console.WriteLine(result);
        }

        public static void pageCount()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int p = Convert.ToInt32(Console.ReadLine());

            int result = ImplementationSolutions.pageCount(n, p);

            System.Console.WriteLine(result);
        }


        public static void electronicShop()
        {
            Console.Clear();
            string text1 = "A person wants to determine the most expensive computer keyboard and USB drive that can be purchased with a give budget. ";
            string text2 = "Type budget and number of keyboards and USB drivers splitted by space:";
            Console.WriteLine(text1);
            Console.WriteLine(text2);

            int[] bnm = Tools.getArrayInt(3," ",0, 100000);
           
            int b = bnm[0];

            /*
            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);
            */

            string text3 = "Type keyboard prices splited by spaces:";
            Console.WriteLine(text3);
            int[] keyboards = Tools.getArrayInt(bnm[1], " ", 0, 1000000);

            string text4 = "Type USB prices splited by spaces:";
            Console.WriteLine(text4);
            int[] drives = Tools.getArrayInt(bnm[2], " ", 0, 1000000);
            /*
             * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
             */
            int moneySpent = ImplementationSolutions.electronicShop(b, keyboards, drives);
            /* int moneySpent = getMoneySpent(keyboards, drives, b); */
            if (moneySpent > -1)
            {
                Console.WriteLine("The highest sum is " + moneySpent);
            }
            else
            {
                Console.WriteLine("There is no valid price combination");
            }
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
        
    }
}