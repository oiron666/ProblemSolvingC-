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

    class Program {

        // Complete the compareTriplets function below.
        
    
        static void Main(string[] args) 
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            // List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            // List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            // List<int> result = Solutions.compareTriplets(a, b);

            // System.Console.WriteLine(result[0]);
            // System.Console.WriteLine(result[1]);

            System.Console.WriteLine("choose problem to solve \n1. simpleArraySum \n2. compareTriplets \n3. aVeryBigsum");
            int switchNo;
            switchNo = Convert.ToInt32(Console.ReadLine()) ;
            // Problems.simpleArraySum();
            switch (switchNo)
            {
                case 1:
                    Problems.simpleArraySum();
                    break;
                case 2:
                    Problems.compareTriplets();
                    break;
                case 3:
                    Problems.aVeryBigsum();
                    break;
                default:
                    break;

                
            }

        }
    
    }
}