using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceAssignment1
{
    public class MethodService : IMethodService
    {
        public bool PrimeNumber(int number)
        {
            int c = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    c++;
                }
            }
            if (c == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int SumOfDigits(int sumNumber)
        {
            if (sumNumber != 0)
            {
                return (sumNumber % 10 + SumOfDigits(sumNumber / 10));
            }
            else
            {
                return 0;
            }
        }

        public string ReverseString(string sReverse)
        {
            char[] reverseArray = sReverse.ToCharArray();
            Array.Reverse(reverseArray);
            return new string(reverseArray);
        }

        public string HTMLTag(string tag, string txt)
        {
            return $"<{tag}>{txt}</{tag}>";
        }

        public string SortNumbers(string sortType, int num1, int num2, int num3, int num4, int num5)
        {
            int[] sortArray = { num1, num2, num3, num4, num5 };
            Array.Sort(sortArray);
            if (sortType == "Descending")
            {
                Array.Reverse(sortArray);
            }
            return $"{sortArray[0]},{sortArray[1]},{sortArray[2]},{sortArray[3]},{sortArray[4]}";
        }



    }
}
