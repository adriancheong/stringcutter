using System;

namespace StringCutter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter input string:");
            var input = System.Console.ReadLine().Trim();
            var result = cutOutString(input, "ab");
            Console.WriteLine(result);
        }

        public static string cutOutString(string input, string stringToCut)
        {
            var leftCharPos = findLeftCharPos(input, stringToCut);
            if (leftCharPos == -1)
                return input;
            var rightCharPos = leftCharPos + 1;

            while (leftCharPos > 0 && rightCharPos < input.Length - 1 && charToTheLeftIsTheSame(input, leftCharPos) && charToTheRightIsTheSame(input, rightCharPos))
            {
                leftCharPos--;
                rightCharPos++;
            }

            return input.Remove(leftCharPos, rightCharPos - leftCharPos + 1);
        }

        private static bool charToTheRightIsTheSame(string input, int rightCharPos)
        {
            return rightCharPos < input.Length - 1 && input[rightCharPos] == input[rightCharPos + 1];
        }

        private static bool charToTheLeftIsTheSame(string input, int leftCharPos)
        {
            return leftCharPos > 0 && input[leftCharPos] == input[leftCharPos - 1];
        }

        private static int findLeftCharPos(string input, string stringToCut)
        {
            return input.IndexOf(stringToCut);
        }
    }
}