using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Services.Description;

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

        public int SumOfDigits(string input)
        {
            List<int> digits = new List<int>();
            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                digits.Add(Convert.ToInt32(input.Substring(i, 1)));
            }

            foreach (int i in digits)
            {
                result = result + i;
            }

            return result;
        }

        public string ReverseString(string input)
        {
            List<string> chars = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                chars.Add(input.Substring(i, 1));
            }
            string result = "";
            for (int i = chars.Count - 1; i > -1; i--)
            {
                result += chars[i];
            }
            return result;
        }

        public string HTMLTag(string tag, string data)
        {
            return $"<{tag}>{data}</{tag}>";
        }

        public string SortNumbers(string sort, string input)
        {

            int[] digits = new int[5];
            string result = "";

            for (int i = 0; i < 5; i++)
            {
                digits[i] = Convert.ToInt32(input.Substring(i, 1));
            }

            if (sort == "1")
            {
                Array.Sort(digits);
            }
            else if (sort == "2")
            {
                Array.Sort(digits);
                Array.Reverse(digits);
            }
            foreach (int i in digits)
            {
                result += i.ToString() + " ";
            }

            return (result);
        }
    }
}
