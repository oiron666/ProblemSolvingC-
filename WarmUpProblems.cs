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
            
            // int arCount = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Type numbers to sum up delimit them by spaces");
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = WarmUpSolutions.simpleArraySum(ar);
            System.Console.WriteLine(result);
            return 1;
        }

        public static List<int>  compareTriplets() 
        {

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = WarmUpSolutions.compareTriplets(a, b);
            System.Console.WriteLine(result[0]);
            System.Console.WriteLine(result[1]);
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