using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class MakingAnagrams
    {

        public void makeAnagram()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            char[] aArray = a.ToCharArray();
            char[] bArray = b.ToCharArray();
            int n = aArray.Length;
            int m = bArray.Length;

            List<char> matchedLetters = new List<char>();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (aArray[i] == bArray[j])
                    {
                        matchedLetters.Add(aArray[i]);
                        aArray[i] = bArray[j] = '0';
                        break;
                    }
                       
                }
                   
            }
               

            int minimumDeletionsToMakeAnagram = (aArray.Length - matchedLetters.Count) + (bArray.Length - matchedLetters.Count);
            Console.WriteLine(minimumDeletionsToMakeAnagram); 
        }
    }
}
