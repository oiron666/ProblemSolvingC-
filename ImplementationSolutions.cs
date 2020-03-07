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
    public class ImplementationSolutions
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int>  finalGrades =  new List<int>();           
            int i = 0;
            for (i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 38)
                {
                    finalGrades.Add(grades[i]);
                }
                else if (grades[i] % 5 > 2)
                {
                    finalGrades.Add((grades[i] - (grades[i] % 5)) + 5);
                }
                else
                {
                    finalGrades.Add(grades[i]);
                }
            }
            return finalGrades;
        }

        public static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) 
        {
            // s:t house range 7 11
            // a position of apple tree  b position of orange tree 5 15
            // apples = distances of apples, oranges = distances of oranges -2, 2, 1  aand 5 -6
            //if (s >= 1 && s <= 10000 &&  t >= 1 && t <= 10000 && a >= 1 && a <= 10000 && b >= 1 && b <= 10000 && a < s && s < t && t < b)
            {
                int iA = 0;
                int iO = 0;
                int numberOfApples = apples.Length;
                int numberOfOranges = oranges.Length;
                long applesResult = 0;
                long orangesResult = 0;
                for (iA = 0; iA <  numberOfApples; iA++)
                {
                    int applePosition = a + apples[iA];
                    if (applePosition >= s && applePosition <= t  )
                    {
                        applesResult ++;
                    }
                }

                for (iO = 0; iO <  numberOfOranges; iO++)
                {
                    int orangePosition = b + oranges[iO];
                    if (orangePosition <= t && orangePosition >= s)
                    {
                        orangesResult ++;
                    }
                }
                System.Console.WriteLine(applesResult);
                System.Console.WriteLine(orangesResult);
            }
          
        }
        public static string kangaroo(int x1, int v1, int x2, int v2) {

            string output;
            int distance1 = x1;
            int distance2 = x2;
            while(true)
            {
                distance1 += v1;
                distance2 += v2;
                if(distance1 == distance2)
                {
                    output = "YES";
                    break;
                }
                if((x1 > x2 && distance1 < distance2) || (x1 < x2 && distance1 > distance2))
                {
                    output = "NO";
                    break;
                }
            }
            return output;
            }
        public static int betweenTwoSets(List<int> a, List<int> b) 
        {
            int output;
            int i;
            int iA;
            int iB;
            int aLength = a.Count;
            int bLength = b.Count;
            int modA = 0;
            int modB = 0;
            List<int>  listA =  new List<int>();    
            List<int>  listB =  new List<int>();  
            for (i = a.Max(); i <= b.Min(); i++ )
            {
                for (iA = 0; iA < aLength; iA ++)
                {
                    if (i%a[iA] == 0)
                    {   
                        modA ++;                  
                    }
                    if (modA == aLength )
                    {
                        listA.Add(i);
                    }
                }
                for (iB = 0; iB < bLength; iB ++)
                {
                    if (b[iB]%i == 0)
                    {   
                        modB ++;                    
                    }
                    if (modB == bLength )
                    {
                        listB.Add(i);
                    }                    
                }
                modA = 0;
                modB = 0;
            }
            IEnumerable<int> listC = listA.Intersect(listB);
            output = listC.Count();
            return output;
            }
        
        public static int[] breakingRecords(int[] scores) 
        {
            int[] output = new int[2];
            int i;
            int initialScore = scores[0];
            int highScore = initialScore;
            int lowScore = initialScore;
            int highScoreCnt = 0;
            int lowScoreCnt = 0;
            for (i = 1; i < scores.Count(); i++)       
            {
                if( scores[i] > highScore)
                {
                    highScoreCnt++;
                    highScore = scores[i];
                }
                if( scores[i] < lowScore)
                {
                    lowScoreCnt++;
                    lowScore = scores[i];
                }
            }
            output[0] = highScoreCnt;
            output[1] = lowScoreCnt;
            return output;
        }

        public static int birthday(List<int> s, int d, int m) 
        {
            int i = 0;
            int j= 0;
            int output = 0;
            while (true)
            {
                int chocoCheck = 0;
                for (i = j; i < j + m; i++)
                {
                    chocoCheck += s[i];
                }
                
                if (chocoCheck == d)
                {
                    output++;
                }
                if (j + m == s.Count)
                {
                    break;
                }
                j++;
            }
            return output;
        }

        public static int divisibleSumPairs(int n, int k, int[] ar) 
        {
            int i = 0;
            int j= 0;
            int sumCheck = 0;
            while (true)     
            {
                for (i = j ; i < ar.Count(); i++)
                {
                    if (((ar[j] + ar[i])%k == 0) && i != j)
                    {
                        // System.Console.WriteLine("{0} {1}",ar[j], ar[i]);
                        sumCheck++;
                    }
                }
                if(j == ar.Count() - 1)
                {
                    break;
                }
                j++;
            }

            return sumCheck;
        }

        public static int migratoryBirds(List<int> arr)
        {
            List<int> arr2 = arr;
            var result = (from score in arr2 group score by score into g orderby g.Count() descending select new {id = g.Key, Count = g.Count()}).First();
            // int result2; 
            //result2 = (arr.GroupBy (a => a).OrderBy (a => a.Key).OrderByDescending (a => a.Count ()).Select (a => a.Key).First ());
            int output = result.id;
            return output;

            
        }

        public static string dayOfProgrammer(int year) 
        {
            DateTime date = new DateTime(year, 1, 1);
            DateTime date1;
            if (year == 1918)
            {
                date1 = date.AddDays(255 + 13); 
            }
            else if (year%100 == 0 && year < 1918)
            {
                date1 = date.AddDays(254); 
            }
            else
            {
                date1 = date.AddDays(255);
            }
            //string dateString = date1.ToString( "DD,MM,YYYY");
            string output =date1.ToString("dd.MM.yyyy");

            return output;

        }

        public static void bonAppetit(List<int> bill, int k, int b)
        {
            bill.RemoveAt(k);
            int sum = bill.Sum();
            if(sum/2 == b)
            {
                System.Console.WriteLine("Bon Appetit");
            }
            else
            {
                System.Console.WriteLine(b - sum/2);
            }

        }
        public static int sockMerchant(int n, int[] ar) 
        {
            int[] distinctAr = ar.Distinct().ToArray();
            int amount;
            int output = 0;
            foreach(int i in distinctAr)
            {
                amount = 0;
                foreach (int j in ar)
                {
                    if (i == j)
                    {
                        amount++;
                    }
                }
                output += amount/2;

                
            }
            return output;
        }  

        public static int   pageCount(int n, int p) 
        {
            return 42;
        }   
    }
}