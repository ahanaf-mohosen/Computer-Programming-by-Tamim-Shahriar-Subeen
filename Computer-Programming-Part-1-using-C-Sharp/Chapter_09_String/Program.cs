using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_09_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CpBook_1, Problem: 9.1
            char[] country = { 'B', 'a', 'n', 'g', 'l', 'a', 'd', 'e', 's', 'h' };
            string countryString = new string(country);
            Console.WriteLine(countryString);
            #endregion

            #region CpBook_1, Problem: 9.2
            //char[] country = { 'B', 'a', 'n', 'g', 'l', 'a', 'd', 'e', 's', 'h', ' ', 'i', 's', ' ', 'm', 'y', ' ', 'c', 'o', 'u', 'n', 't', 'r', 'y' };
            //string countryString = new string(country);
            //Console.WriteLine(countryString);
            #endregion

            #region CpBook_1, Problem: 9.3
            //char[] country = { 'B', 'a', 'n', 'g', 'l', 'a', 'd', 'e', 's', 'h', '\0', 'i', 's', ' ', 'm', 'y', ' ', 'c', 'o', 'u', 'n', 't', 'r', 'y' };
            //string countryString = new string(country, 0, Array.IndexOf(country, '\0'));
            //Console.WriteLine(countryString);
            #endregion

            #region CpBook_1, Problem: 9.4
            //char[] country = { 'B', 'a', 'n', 'g', 'l', 'a', 'd', 'e', 's', 'h' };
            //int length = 10;

            //Console.WriteLine(new string(country));

            //for (int i = 0; i < length; i++)
            //{
            //    if (country[i] >= 'a' && country[i] <= 'z')
            //    {
            //        country[i] = (char)('A' + (country[i] - 'a'));
            //    }
            //}

            //Console.WriteLine(new string(country));
            #endregion

            #region CpBook_1, Problem: 9.5
            //string country;
            //while (true)
            //{
            //    country = Console.ReadLine();
            //    int length = StringLength(country);
            //    Console.WriteLine($"length: {length}");
            //}

            //static int StringLength(string str)
            //{
            //    int length = 0;
            //    foreach (char c in str)
            //    {
            //        length++;
            //    }
            //    return length;
            //}
            #endregion

            #region CpBook_1, Problem: 9.6
            //string ara;
            //while ((ara = Console.ReadLine()) != null)
            //{
            //    Console.WriteLine(ara);
            //}
            #endregion

            #region CpBook_1, Problem: 9.7
            //string str1 = "bangla";
            //string str2 = "desh";
            //char[] str3 = new char[str1.Length + str2.Length + 1];

            //int i, j;
            //for (i = 0, j = 0; i < str1.Length; i++, j++)
            //{
            //    str3[j] = str1[i];
            //}

            //for (i = 0; i < str2.Length; i++, j++)
            //{
            //    str3[j] = str2[i];
            //}

            //str3[j] = '\0';

            //Console.WriteLine(new string(str3, 0, j)); // Convert char array to string for output
            #endregion

            #region CpBook_1, Problem: 9.8
            //string s = Console.ReadLine();
            //char[] word = new char[100];
            //int j = 0;
            //bool isWordStarted = false;

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] >= 'a' && s[i] <= 'z')
            //    {
            //        if (!isWordStarted)
            //        {
            //            isWordStarted = true;
            //            word[j] = (char)('A' + s[i] - 'a'); // Capitalize the first letter
            //            j++;
            //        }
            //        else
            //        {
            //            word[j] = s[i];
            //            j++;
            //        }
            //    }
            //    else if (s[i] >= 'A' && s[i] <= 'Z')
            //    {
            //        if (!isWordStarted)
            //        {
            //            isWordStarted = true;
            //        }
            //        word[j] = s[i];
            //        j++;
            //    }
            //    else if (s[i] >= '0' && s[i] <= '9')
            //    {
            //        if (!isWordStarted)
            //        {
            //            isWordStarted = true;
            //        }
            //        word[j] = s[i];
            //        j++;
            //    }
            //    else
            //    {
            //        if (isWordStarted)
            //        {
            //            isWordStarted = false;
            //            word[j] = '\0'; // Null-terminate the word
            //            Console.WriteLine(new string(word, 0, j)); // Print the word
            //            j = 0;
            //        }
            //    }
            //}
            #endregion

            #region CpBook_1, Problem: 9.9
            //string s = Console.ReadLine();
            //bool isWordStarted = false;

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] >= 'a' && s[i] <= 'z')
            //    {
            //        if (!isWordStarted)
            //        {
            //            isWordStarted = true;
            //            char ch = (char)('A' + s[i] - 'a'); // Capitalize the first letter
            //            Console.Write(ch);
            //        }
            //        else
            //        {
            //            Console.Write(s[i]);
            //        }
            //    }
            //    else if ((s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= '0' && s[i] <= '9'))
            //    {
            //        if (!isWordStarted)
            //        {
            //            isWordStarted = true;
            //        }
            //        Console.Write(s[i]);
            //    }
            //    else
            //    {
            //        if (isWordStarted)
            //        {
            //            isWordStarted = false;
            //            Console.WriteLine(); // Print a new line after a word
            //        }
            //    }
            //}
            //Console.WriteLine(); // Ensure a final newline at the end
            #endregion
        }
    }
}
