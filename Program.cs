using System;
using System.Collections.Generic;
using System.Linq;

namespace coding_challenge_399
{
    class Program
    {
        private static string[] strings = {};

        // Step 0
        static int LetterSum(string word)
        {
            return -1;
        }

        // Step 1
        static string SingleWordWithGivenLetterSum(int length)
        {
            return "";
        }

        // Step 2.a
        static int NumOfOddSum()
        {
            return 0;
        }

        // Step 2.b
        static int NumOfEvenSUm()
        {
            return 0;
        }

        // Step 3
        /// <summary>First has to be the sum, the second the number.</summary>
        /// <returns>The most common letter sum and the number of words having that letter sum.</returns>
        static (int, int) MostCommonLetterSum()
        {
            return (0, 0);
        }

        // Step 4
        static (string, string) SameSumDifferLength()
        {
            return ("", "");
        }

        // Step 5
        static IEnumerable<(string, string)> SameSumNoCommonLetters()
        {
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

            Console.WriteLine(score);
        }
    }
}
