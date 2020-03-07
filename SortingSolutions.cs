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
    public class SortingSolutions
    {
        public static int introTutorial(int V, int[] arr) 
        {
            int i;
            for(i = 0; i < arr.Count(); i++)
            {
                if (arr[i] == V)
                {
                    break;
                }
            }
            return i;
        }
    }
}