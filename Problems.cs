using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace problemSolving
{
    public class Problems
    {
        public static int simpleArraySum() {
            
            // int arCount = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Type numbers to sum up delimit them by spaces");
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = Solutions.simpleArraySum(ar);
            System.Console.WriteLine(result);
            return 1;
        }

        public static List<int>  compareTriplets() {

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = Solutions.compareTriplets(a, b);
            System.Console.WriteLine(result[0]);
            System.Console.WriteLine(result[1]);
            return result;
        }

        public static long aVeryBigsum() {

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
            long result = Solutions.aVeryBigSum(ar);
            System.Console.WriteLine(result);
            return result;

        }

         public static int diagonalDifference(){
            
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

        
    }
}