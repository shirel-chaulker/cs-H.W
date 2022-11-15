using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework14112022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = "hello world";
            string str1 = "hello world my name is shirel";

            Console.WriteLine(str1.Contains(str));

            //Contains(t ou f)
            //  Returns a value indicating whether a str1 occurs
            //  within str.


            //Copy To
            //  Copies a specified number of characters from a specified position in this instance
            //  to a specified position in an array of Unicode characters.
            string str2 = "my name is jovani but everyone call me jorjio";
            char[] dest = new char[55];
            str2.CopyTo(3, dest, 0, 4);

            Console.WriteLine(dest);

            //Insert
            // Returns a new string in which a specified string is inserted at a specified index
            // position in this instance. (let you insert new string at any place in an exsiting string)

            string str3 = "shireldansasha";
            string str4;
            str4 = str3.Insert(5, " ");
            Console.WriteLine(str4);

            //PadRight 
            //returns new string with length 20 
            //  padded with space at right  
            string result;
            string str5 = "icecream";
            result = str5.PadRight(20);
            Console.WriteLine("|{0}|", result);
            //Replace
            //This func let you replace between two diffrent char's.
            string str6 = "GeeksForGeeks";
            Console.WriteLine(str6.Replace('s', 'G'));

            //Substring
            // Let you decide where to cut a string and how much to cut.
            Console.WriteLine(str6.Substring(5, 8));

            //ToCharArray
            //convert string to arry
            char[] hadash;
            hadash = str6.ToCharArray();
            for (int i = 0; i < hadash.Length; i++)
            {
                Console.WriteLine(hadash[i] + ", ");
            }

            //splite
            //
            string[] result1 = str2.Split();
            for (int i = 0; i < result1.Length; i++)
            {
                Console.WriteLine(result1[i] + ", ");
            }

            //trim
            //revome spaces from the start and the end.
            string text = "    Ice dogg   _";
            string s1 = text.Trim();
            Console.WriteLine(s1);

            //trim start
            // remove spaces only from the begining.
            string s2 = text.TrimStart();
            Console.WriteLine(s2);

            //Start with
            //boolian, return TRUE  if the string or char starting the same.(or not and FALSE)
            string text1 = "Ice dom";
            Console.WriteLine(text1.StartsWith("Ice"));

            //Index of
            //return  the place of a char or a string that contains our specification.
            int result3 = text1.IndexOf("dom");
            Console.WriteLine(result3);
            Console.ReadLine();

            void func(string string1, string string2)
            {
                ///string1=anigadolmeod
                ///string2=meod


            }
        }
    }
}
