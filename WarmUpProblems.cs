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
    public class WarmUpProblems
    {

        public static int simpleArraySum()
        {
            Console.Clear();
            string description = "Given an array of integers, find the sum of its elements";
            string description2 = "For example, if the array ar = [1,2,3] 1 + 2 + 3 so return 6";
            Console.WriteLine(description);
            Console.WriteLine(description2);
            // int arCount = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Type numbers to sum up delimit them by spaces");
            int[] ar;

            try
            {
                ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
                int result = WarmUpSolutions.simpleArraySum(ar);
                System.Console.WriteLine("The result of sum is " + result);
                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("\nWrite number correctly \nPress any key to continue");
                Console.ReadKey();
                simpleArraySum();
            }
            return 1;

        }

        public static List<int>  compareTriplets() 
        {
            Console.Clear();
            Console.WriteLine("The task is to find comparison points by comparing a[0] with b[0], a[1] with b[1], and a[2] with b[2].");
            Console.WriteLine("If a[i] > b[i], then A is awarded 1 point.");
            Console.WriteLine("If a[i] < b[i], then B is awarded 1 point. ");
            Console.WriteLine("If a[i] = b[i], then neither person receives a point.");
            //List<int> a = new List<int>() {} ;
            //List<int> b = new List<int>() {};
            List<int> a = Tools.getListInt(3, " ", 0, 1000000);
            List<int> b = Tools.getListInt(3, " ", 0, 1000000);

            List<int> result = WarmUpSolutions.compareTriplets(a, b);
            Console.WriteLine("A scored {0} points", result[0]);
            Console.WriteLine("B scored {0} points", result[1]);
            if (result[0] > result[1])
                Console.WriteLine("A won");
            else if (result[0] < result[1])
                Console.WriteLine("B won");
            else
                Console.WriteLine("It's a draw");


            Console.WriteLine("\nPress any key to go to Main Menu");
            Console.ReadKey();
            return result;
        }

        public static long aVeryBigsum() 
        {

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
            long result = WarmUpSolutions.aVeryBigSum(ar);
            System.Console.WriteLine(result);
            return result;

        }

         public static int diagonalDifference()
         {
            
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = WarmUpSolutions.diagonalDifference(arr);
            //System.Console.WriteLine(arr.Count);
            System.Console.WriteLine(result);
            return result;

         }

        public static void plusMinus()
        {
      
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            WarmUpSolutions.plusMinus(arr);

        }

        public static void staircase() 
        {

            int n = Convert.ToInt32(Console.ReadLine());
            WarmUpSolutions.staircase(n);

        }

        public static void miniMaxSum() 
        {

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            WarmUpSolutions.miniMaxSum(arr);

        }

        public static void birthdayCakeCandles()
        {

            int arCount = Convert.ToInt32(Console.ReadLine());
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = WarmUpSolutions.birthdayCakeCandles(ar);
            System.Console.WriteLine(result);

        }

        public static void timeConversion()
        {

            string s = Console.ReadLine();
            string result = WarmUpSolutions.timeConversion(s);
            System.Console.WriteLine(result);

        }
    }
}