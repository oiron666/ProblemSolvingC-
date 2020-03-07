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
    public class WarmUpSolutions
    {
        public static int simpleArraySum(int[] ar) 
        {
        int a = 0;
        foreach (int i in ar)
        {
            a += i;
        }
        return a;
        }
    

    public static List<int> compareTriplets(List<int> a, List<int> b) 
        {
            int scoreA = 0;
            int scoreB = 0;
            int i;
            for ( i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    scoreA++;
                }
                else if (a[i] < b[i])
                {
                    scoreB++;
                }
            }
            List<int>  resultArray =  new List<int>() { scoreA,scoreB};

            return resultArray;
        }


        public static long aVeryBigSum(long[] ar) 
        {
            long a = 0;
            foreach (int i in ar)
            {
            a += i;
            }
            return a;
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int scoreLeft = 0;
            int scoreRight = 0;
            int i = 0;
            int rightCounter = arr.Count - 1;
            int totalScore;
            for ( i = 0; i < arr.Count; i++)
            {
                scoreLeft += arr[i][i];
                scoreRight += arr[i][rightCounter];
                rightCounter --;

            }
            totalScore = Math.Abs(scoreLeft - scoreRight);
            return totalScore;
        }


        public static void plusMinus(int[] arr)
        {
            double denominator = arr.Count();
            double positiveCounter = 0;
            double negativeCounter = 0;
            double zeroCounter = 0;
            foreach (int i in arr){
                if(i > 0)
                {
                    positiveCounter ++;
                }
                else if (i < 0)
                {
                    negativeCounter ++;
                }
                else
                {
                    zeroCounter ++;
                }
            }
            double result;
            result = Math.Round((positiveCounter)/(denominator), 6);   
            double resultPostive = result;
            result =  Math.Round((negativeCounter)/(denominator), 6);
            double resultNegative = result;
            result = Math.Round((zeroCounter)/(denominator), 6);
            double resultZero = result;
            System.Console.WriteLine(resultPostive);
            System.Console.WriteLine(resultNegative);
            System.Console.WriteLine(resultZero);
        }

        public static void staircase(int n) 
        {
            int i = 1;
            for (i = 1; i <= n; i++ )
            {
                string space = String.Concat(Enumerable.Repeat(" ", n - i));
                string sharp = String.Concat(Enumerable.Repeat("#", i));
                System.Console.WriteLine(String.Concat(space, sharp));
            } 

        }


        public static void miniMaxSum(int[] arr) {
            int maxNumber = arr.Max();
            int minNumber = arr.Min();
            long totalSum = 0;
            long maxSum = 0;
            long minSum = 0;
            foreach (int i in arr)
            {
                totalSum += i;
            }

            maxSum = totalSum - minNumber;
            minSum = totalSum - maxNumber;
            Console.WriteLine("{0} {1}",minSum, maxSum);
        } 

        public static int birthdayCakeCandles(int[] ar)
        {
            
            int maxHeight = ar.Max();
            int candlesToBlow = 0;

            foreach(int i in ar)
            {
                if (maxHeight == i)
                {
                    candlesToBlow ++;
                }

            }
            return candlesToBlow;

        }

        public static string timeConversion(string s) {
            
            string time;
            string PMorAM = s.Substring(s.Length-2, 2);
            string timeOutPMAM =  s.Substring(0, 8);
            string hourString =  s.Substring(0,2);
            if (PMorAM == "PM" && hourString != "12" )
            {               
                int hourInt = Convert.ToInt32(hourString);
                hourInt += 12;
                string correctHour = Convert.ToString(hourInt);
                time = String.Concat(correctHour, timeOutPMAM.Substring(timeOutPMAM.Length - 6, 6));
            }
            else if(PMorAM == "AM" && hourString == "12")
            {
                string correctHour = "00";
                time = String.Concat(correctHour, timeOutPMAM.Substring(timeOutPMAM.Length - 6, 6));
            }
            else
            {
                time = timeOutPMAM;
            }
            
            return time;

        }                                


    }
}