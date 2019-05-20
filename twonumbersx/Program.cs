using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twonumbersx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements in S:");
            int n = Convert.ToInt16(Console.ReadLine());
            int[] S = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"S[{i + 1}]=");
                S[i] = Convert.ToInt32(Console.ReadLine());


            }
            Console.Write("Enter the value of X:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write(TwoIntegersSumToTarget(S,x));
            Console.ReadLine();
        }
        
          public static bool TwoIntegersSumToTarget(int[] S, int x)
          {
               for (int i = 0; i < S.Length; i++)
               {
                   for (int j = i+1; j < S.Length; j++)
                   {
  
                         if (S[i] + S[j] == x)
                         return true;
                      
                   }
               }
              return false;
          }
        
    }
}
