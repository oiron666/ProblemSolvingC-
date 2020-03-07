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
    public class SortingProblems
    {
        public static void introTutorial() 
        {
        int V = Convert.ToInt32(Console.ReadLine());

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        int result = SortingSolutions.introTutorial(V, arr);

        System.Console.WriteLine(result);
        }
    }
}