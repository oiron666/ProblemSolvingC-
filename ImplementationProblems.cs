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

    }
}