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
    public class StringProblems
    {
        public static void reducedStrings()
        {

            string s = Console.ReadLine();
            string result = StringSolutions.superReducedString(s);
            System.Console.WriteLine(result);

        }

        public static void camelcase() 
        {
            string s = Console.ReadLine();

            int result = StringSolutions.camelcase(s);

            System.Console.WriteLine(result);


        }

        public static void minimumNumber()
        {

            int n = Convert.ToInt32(Console.ReadLine());
            string password = Console.ReadLine();
            int answer = StringSolutions.minimumNumber(n, password);
            System.Console.WriteLine(answer);
 
        } 

        public static void alternate() 
        {

            int l = Convert.ToInt32(Console.ReadLine().Trim());
            string s = Console.ReadLine();           
            int result = StringSolutions.alternate(s);
            System.Console.WriteLine(result);

        }

        public static void caesarCipher()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine());

            string result = StringSolutions.caesarCipher(s, k);

            Console.WriteLine(result);
        }


    }
}