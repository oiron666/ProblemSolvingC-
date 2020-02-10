using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace problemSolving
{
    public class Problems
    {
        public static int simpleArraySum() 
        {
            
            // int arCount = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Type numbers to sum up delimit them by spaces");
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = Solutions.simpleArraySum(ar);
            System.Console.WriteLine(result);
            return 1;
        }

        public static List<int>  compareTriplets() 
        {

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = Solutions.compareTriplets(a, b);
            System.Console.WriteLine(result[0]);
            System.Console.WriteLine(result[1]);
            return result;
        }

        public static long aVeryBigsum() 
        {

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
            long result = Solutions.aVeryBigSum(ar);
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

            int result = Solutions.diagonalDifference(arr);
            //System.Console.WriteLine(arr.Count);
            System.Console.WriteLine(result);
            return result;

         }

        public static void plusMinus()
        {
      
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            Solutions.plusMinus(arr);

        }

        public static void staircase() 
        {

            int n = Convert.ToInt32(Console.ReadLine());
            Solutions.staircase(n);

        }

        public static void miniMaxSum() 
        {

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            Solutions.miniMaxSum(arr);

        }

        public static void birthdayCakeCandles()
        {

            int arCount = Convert.ToInt32(Console.ReadLine());
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = Solutions.birthdayCakeCandles(ar);
            System.Console.WriteLine(result);

        }

        public static void timeConversion()
        {

            string s = Console.ReadLine();
            string result = Solutions.timeConversion(s);
            System.Console.WriteLine(result);

        }

        public static void reducedStrings()
        {

            string s = Console.ReadLine();
            string result = Solutions.superReducedString(s);
            System.Console.WriteLine(result);

        }

        
        public static void gradingStudents()
        {

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Solutions.gradingStudents(grades);
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
            Solutions.countApplesAndOranges(s, t, a, b, apples, oranges);
        }
        
    }
}