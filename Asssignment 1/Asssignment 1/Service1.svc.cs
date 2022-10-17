using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Asssignment_1
{
    
    public class Service1 : IService1
    {
       public string GetPrime_Number(int pn)
        {
            int i;
            int num = pn / 2;
            for (i = 2; i <= num; i++)
            {
                if (pn % i == 0)
                {
                    break;
                }
            }
            if (i > num)
            {
                return "THE NUMBER IS A PRIME NUMBER";
            }
            else
            {
                return "THE NUMBER IS NOT A PRIME NUMBER";
            }
        }
        public string getSum_of_digits(int num)
        {
            int sum = 0;
            int mod;
            while (num > 0)
            {
                mod = num % 10;
                sum = sum + mod;
                num = num / 10;
            }
            return ("THE SUM OF THE DIGITS ARE = " + sum);
        }

        public string reverse_String(string val)
        {
            char[] charArray = val.ToCharArray();

            string reverseString = String.Empty;

            for (int v = charArray.Length - 1; v > -1; v--)
            {
                reverseString += charArray[v];
            }

            return reverseString;
                      
        }

        public string html_tags(string value , string val)
        {
            if (value != null)
            {
                return ("<" + value  + ">" + val + "</"  + value  + ">" );
            }
            return null;
        }

        public string sort_Numbers(string asc_desc,int number ,  int val , int value , int num , int n)
        {
            int[] Ar = new int[] {number , val , value , num , n};
            if (asc_desc == "ASC")
            {
                Array.Sort<int>(Ar);
                return string.Join(",", Ar);

            }
            else if (asc_desc == "DESC")
            {

                Array.Sort<int>(Ar);
                Array.Reverse(Ar);
                return string.Join(",", Ar);

            }
            return null;
        }

    }

}
