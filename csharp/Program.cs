using System;
using System.Collections.Generic;
using System.Linq;

namespace coding_challenge_399
{
    class Program
    {
        // Container of given strings.
        private static string[] strings = {};

        /// <summary>
        /// Returns the sum of chars of the given word.
        /// <example>
        /// If you have the word "aba", the sum of his chars will be:
        /// a = 1, b = 2, a = 1 => a + b + a = 1 + 2 + 1 = 4
        /// </example>
        /// </summary>
        static int LetterSum(string word)
        {
            // Write here the code for step 0
            return -1;
        }

        /// <summary>
        /// Returns the word of the given letter sum.
        /// <example>
        /// If you have the length 4, you will get "aba".
        /// </example>
        /// </summary>
        static string SingleWordWithGivenLetterSum(int length)
        {
            // Write here the code for step 1
            return "";
        }

        /// <summary>
        /// Returns the number of odd letter sum words.
        /// <example>
        /// If you have words "aba", "ab" and "a", you will get 2.
        /// </example>
        /// </summary>
        static int NumOfOddSum()
        {
            // Write here the code for step 2
            return 0;
        }

        /// <summary>
        /// Returns the number of even letter sum words.
        /// <example>
        /// If you have words "aba", "ab" and "a", you will get 1.
        /// </example>
        /// </summary>
        static int NumOfEvenSUm()
        {
            // Write here the code for step 2
            return 0;
        }

        /// <summary>
        /// Returns the most common letter sum and the absolute number.
        /// <example>
        /// If you have words "aba", "ab" and "aba", you will get (3, 2).
        /// </example>
        /// </summary>
        static (int, int) MostCommonLetterSum()
        {
            // Write here the code for step 3
            return (0, 0);
        }

        /// <summary>
        /// Returns the two strings with same letter sum but lengths different
        /// by 11.
        /// <example>
        /// If you have words "zyzzyva" and "biodegradabilities", the return
        /// will be ("zyzzyva", "biodegradabilities").
        /// </example>
        /// </summary>
        static (string, string) SameSumDifferLength()
        {
            // Write here the code for step 4
            return ("", "");
        }

        /// <summary>
        /// Returns the two strings with same letter sum but no chars in common.
        /// <example>
        /// If you have words "cytotoxicity" and "unreservedness", the return
        /// will be a List of strings as [("cytotoxicity", "unreservedness")].
        /// </example>
        /// </summary>
        static IEnumerable<(string, string)> SameSumNoCommonLetters()
        {
            // Write here the code for step 5
            return new (string, string)[] {
                ("", "")
            };
        }

        // Don't modify this function.
        static void Main(string[] args)
        {
            strings = System.IO.File.ReadAllText("enable1.txt").Split("\n");

            var score = 0;

            // Score step 0
            var lettersumScores = new Dictionary<string, int>();
            lettersumScores.Add("", 0);
            lettersumScores.Add("a", 1);
            lettersumScores.Add("z", 26);
            lettersumScores.Add("cab", 6);
            lettersumScores.Add("excellent", 100);
            lettersumScores.Add("microspectrophotometries", 317);
            foreach(var elem in lettersumScores)
                if(LetterSum(elem.Key) == elem.Value) score++;

            // Score step 1
            if(SingleWordWithGivenLetterSum(319) == "reinstitutionalizations") score++;

            // Score step 2
            if(NumOfOddSum() == 86339) score++;
            if(NumOfEvenSUm() == 86485) score++;

            // Score step 3
            if(MostCommonLetterSum() == (93, 1965)) score++;

            // Score step 4
            if(SameSumDifferLength() == ("electroencephalographic", "voluptuously")) score++;

            // Score step 5
            var fifthList = SameSumNoCommonLetters();
            if(fifthList.Contains(("defenselessnesses", "microphotographic"))) score++;
            if(fifthList.Contains(("defenselessnesses", "photomicrographic"))) score++;

            // Output the result.
            Console.WriteLine(score);
        }
    }
}
