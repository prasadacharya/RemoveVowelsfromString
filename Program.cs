

using System;
using System.Text;

namespace RemoveVowelsfromString
{
    class Program
    {

        static void Main(string[] args)
        {
            string A = "aeiou";
            string result = RemoveVowels(A);
            Console.WriteLine(result);
        }
        private static string RemoveVowels(string S)
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'a' || S[i] == 'e' || S[i] == 'i' || S[i] == 'o' || S[i] == 'u')
                    continue;
                else
                    s.Append(S[i]);
            }

            return s.ToString();
        }
    }
}
