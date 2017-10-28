using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumStringAsNumbersCodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumStrings("3019", "14"));
            Console.ReadLine();
        }

        public static string sumStrings(string a, string b)
        {
            string finalString = "";
            int startZeroes;
            string aString;
            string bString;
            int carry = 0;
            int placeTotal;
            // The following if and else make sure zeros are added as needed to make the numbers have the same length.
            // I also reverse the numbers to allow for simpler processing later.
            if (a.Length > b.Length)
            {
                startZeroes = a.Length - b.Length;
                aString = a.Reverse();
                bString = "";
                for (int i = 0; i < startZeroes; i++)
                {
                    bString += "0";
                }
                bString += b;
                bString = bString.Reverse();
            }   
            else  
            {
                startZeroes = b.Length - a.Length;
                bString = b.Reverse();
                aString = "";
                for (int i = 0; i < startZeroes; i++)
                {
                    aString += "0";
                }
                aString += a;
                aString = aString.Reverse();
            }                       

            for (int i = 0; i < aString.Length; i++)
            {
                placeTotal = carry + Convert.ToInt32(aString[i].ToString()) + Convert.ToInt32(bString[i].ToString());
                if (placeTotal > 9)
                {
                    placeTotal = placeTotal - 10;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
                finalString += placeTotal.ToString();
            }
            finalString += carry.ToString();
            finalString = finalString.Reverse();
            if (finalString[0] == '0')
            {
                finalString = finalString.Substring(1);
            }
            if (finalString[0] == '0')
            {
                finalString = finalString.Substring(1);
            }
            return finalString;
        }
    }

    static class StringExtensions    
    {
        public static string Reverse(this string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }
    }   
}
