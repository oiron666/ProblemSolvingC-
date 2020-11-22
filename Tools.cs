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
    public class Tools
    {

        public static List<int> getListInt(int Length, string splitChar, int minValue, int maxValue)
        {
            List<int> listInt;

            while (true)
            {
                bool listLengthValidator = false;
                bool listValueValidator = true;
                try
                {
                    listInt = Console.ReadLine().TrimEnd().Split(splitChar).ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
                    if (listInt.Count > Length)
                    {
                        Console.WriteLine("List is too long! List must contain {0} elements", Length);
                    }
                    else if (listInt.Count < Length)
                    {
                        Console.WriteLine("List is too short! List must contain {0} elements", Length);
                    }
                    else
                    {
                        listLengthValidator = true;
                    }
                    foreach(int i in listInt)
                    {
                        if(i < minValue)
                        {
                            Console.WriteLine("{0} is too small value! Minimum acceptable value is {1}",i, minValue);
                            listValueValidator = false;
                        }
                        else if(i > maxValue)
                        {
                            Console.WriteLine("{0} is too big value! Maximum acceptable value is {1}", i, maxValue);
                            listValueValidator = false;
                        }
                    }
                    if (listLengthValidator == true && listValueValidator == true)
                    {
                        break;
                    }
                    
                }
                catch(Exception)
                {
                    Console.WriteLine("Write integer numbers only");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
            }

            return listInt;

        }

    }
}
