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



namespace problemSolving{

    public class Solutions
    {
        

        public static int simpleArraySum(int[] ar) 
        {
        /*
         * Write your code here.
         */
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
    
    }
}