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
            System.Console.WriteLine("The first score is {0) and the second is {1}",result[0], result[1]);
            return result;
        }

        public static long aVeryBigsum() {

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
            long result = Solutions.aVeryBigSum(ar);
            System.Console.WriteLine(result);
            return result;
            
        }
        
    }
}