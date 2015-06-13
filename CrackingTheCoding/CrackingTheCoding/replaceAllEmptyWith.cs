using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCoding
{
    public class replaceAllEmptyWith
    {

        public string replace(string s)
        {
            char[] ip = new char [100];
             
            int noSpaces = countempty(s, out ip);
            int totalrequired = noSpaces * 2;

            int j = s.Length-1;
            int k;
            while(j>=0)
            {
                if(ip[j] == ' ')
                {
                    k=j+totalrequired;
                    ip[k] = '0';
                    ip[k - 1] = '2';
                    ip[k - 2] = '%';
                    totalrequired -= 2;
                }
                else
                {
                    ip[j + totalrequired] = ip[j];
                }
                j--;
            }


            return new string(ip);
        }

        int countempty(string s, out char [] array)
        {
            array = new char[100];
            int count = 0;
            int i = 0;
            foreach (var c in s)
            {
                array[i++] = c;
                if (c == ' ')
                {
                    count++;
                }
            }
            return count;
        }

    }
}
