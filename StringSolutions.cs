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
    public class StringSolutions
    {
        public static string superReducedString(string s) 
        {
            var reducedString = s;
            bool test = true;
            string output = reducedString;  
            while (test == true)
            {
                int stringLength = reducedString.Length;
                if (stringLength > 2)
                {
                    int i = 0;
                    for (i = 0; i < stringLength; i++)
                    {
                        if (i == stringLength - 1)
                        {
                            test = false;
                            break;
                        }

                        string s1 = reducedString.Substring(i,1);

                        string s2 = reducedString.Substring(i+1,1);
                        if (s1 == s2)
                        {
                            reducedString = reducedString.Remove(i, 2);
                            //reducedString = reducedString.Remove(i + 1, 1);
                            output = reducedString;
                            //System.Console.WriteLine(output);
                            stringLength = reducedString.Length;
                            test = true;
                            break;
                        }
                    }
                }
                else if ((stringLength == 2 &&  reducedString.Substring(0,1) == reducedString.Substring(1,1)) ||  stringLength == 1 )
                {
                    output = "Empty String";
                    test = false;
                    break;
                }
                else
                {
                    output = reducedString;
                    test = false;
                    break;
                }    
            }
            return output;       
        }

        public static int camelcase(string s)
        {
            int i = 0;
            int result = 1;
            char[] character = s.ToCharArray();
            for(i=0; i< s.Length; i++)
            {
                if(char.IsUpper(character[i]))
                {
                    result++;
                }                 
            }
            return result;
        }

        public static int minimumNumber(int n, string password) {
        // Return the minimum number of characters to make the password strong

            int output = 0;
            char[] passwordChar = password.ToCharArray();

            string lower_case = "abcdefghijklmnopqrstuvwxyz";
            char[] lowerCase = lower_case.ToCharArray();
            Boolean lowerCaseTest = false;
            foreach(int i in lowerCase)
            {
                foreach(int j in passwordChar)
                {
                    if(i == j)
                    {
                        lowerCaseTest = true;
                    }
                }
            }
            if (lowerCaseTest == false)
            {
                output++;
            }

            string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] upperCase = upper_case.ToCharArray();
            Boolean upperCaseTest = false;
            foreach(int i in upperCase)
            {
                foreach(int j in passwordChar)
                {
                    if(i == j)
                    {
                        upperCaseTest = true;
                    }
                }
            }
            if (upperCaseTest == false)
            {
                output++;
            }


            string special_characters = "!@#$%^&*()-+";
            char[] specialCharacters = special_characters.ToCharArray();
            Boolean specialCharactersTest = false;
            foreach(int i in specialCharacters)
            {
                foreach(int j in passwordChar)
                {
                    if(i == j)
                    {
                        specialCharactersTest = true;
                    }
                }
            }
            if (specialCharactersTest == false)
            {
                output++;
            }

            string numbers = "0123456789";
            char[] numbersChar = numbers.ToCharArray();
            Boolean numbersTest = false;
            foreach(int i in numbersChar)
            {
                foreach(int j in passwordChar)
                {
                    if(i == j)
                    {
                        numbersTest = true;
                    }
                }
            }
            if (numbersTest == false)
            {
                output++;
            }


            if(password.Length + output < 6)
            {
                output += 6 - (password.Length + output);
            }
                              
            return output;
        }

        public static int alternate(string s) 
        {


        int output;
        if (s.Length > 1)
            {
                int i,j,k;
                string reducedString;
                List<char> charList = new List<char>();               
                charList.AddRange(s); //string to char list
                List<char> charlistDistinct = charList.Distinct().ToList();  //distinct char list
                List<string> listOfPairs = new List<string>();
                listOfPairs .Add("00");
                for (i = 0; i < charlistDistinct.Count() - 1; i++)  //getting the pairs
                {
                    for (j =i + 1; j <  charlistDistinct.Count(); j++)
                    {
                        listOfPairs.Add(String.Concat(charlistDistinct[i],charlistDistinct[j]));
                    }
                }

                List<int> maxValues = new List<int> ();                
                for (k = 0; k < listOfPairs.Count(); k ++)
                {
                    string kp1 =listOfPairs[k].Substring(0,1);
                    string kp2 = listOfPairs[k].Substring(1,1);
                    reducedString = s;
                    for (i = 0; i < listOfPairs.Count(); i ++)
                    {
                        string ip1 = listOfPairs[i].Substring(0,1);
                        string ip2 = listOfPairs[i].Substring(1,1);
                        if (k != i && kp1 != ip1 && kp1 != ip2 && kp2 != ip1 && kp2 != ip2)                     
                        {                          
                            reducedString = reducedString.Replace(ip1, "");
                            reducedString = reducedString.Replace(listOfPairs[i].Substring(1,1), "");       
                        }
                    }
                  
                    for(j = 0; j < reducedString.Length - 1; j++)
                    {
                        if(reducedString.Substring(j,1) == reducedString.Substring(j+1,1))
                        {
                            break;
                        }
                        else if (j == reducedString.Length - 2)
                        {
                            maxValues.Add(reducedString.Length);
                        }
                    }                        
                }
                if (maxValues.Count == 0 )
                {
                    output = 0;
                }   
                else
                {
                    output = maxValues.Max();
                }
            }
            else
            {
                output = 0;
            }
            return output;
        }

        public static string caesarCipher(string s, int k)
        {
            int i;
            List<char> charList = new List<char>();
            charList.AddRange(s);
            int lowerRangeLC = 65;
            int upperRangeLC = 90;
            int lowerRangeUC = 97;
            int upperRangeUC = 122;
            string output = "";
            for (i = 0; i < charList.Count; i++)
            {
                int numAscii = (int)charList[i];
                int shiftedNum = 0;
                char shiftedChar;

                if ((numAscii >= lowerRangeLC && numAscii <= upperRangeLC) || (numAscii >= lowerRangeUC && numAscii <= upperRangeUC))
                {
                    shiftedNum = numAscii + k;
                    
                    if (shiftedNum > upperRangeLC && numAscii < lowerRangeUC)
                    {
                        shiftedNum = lowerRangeLC + (k - (upperRangeLC - numAscii)) -1;
                        while (shiftedNum > upperRangeLC)
                        {
                            shiftedNum = lowerRangeLC + (shiftedNum - upperRangeLC)-1; 
                        }
                    }
                    else if (shiftedNum > upperRangeUC)
                    {
                        shiftedNum = lowerRangeUC + (k - (upperRangeUC - numAscii)) -1;
                        while (shiftedNum > upperRangeUC)
                        {
                            shiftedNum = lowerRangeUC + (shiftedNum - upperRangeUC)-1;
                        }

                    }
                    shiftedChar = (char)shiftedNum;
                }
                else
                {
                    shiftedChar = charList[i];
                }
                output = String.Concat(output, shiftedChar);
                
            }
            return output;
        }

    }
}