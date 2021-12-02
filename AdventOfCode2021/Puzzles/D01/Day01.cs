using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AdventOfCode2020.Puzzles
{
    public class Day01
    {
        [Result(1692)]
        public static int GetAnswer1(int[] input)
        {
            var previous = input.First();
            var countUp = 0;
            foreach (var i in input.Skip(1))
            {
                if (i > previous) countUp++;
                previous = i;
            }

            return countUp;
        }

        [Result(1724)]
        public static int GetAnswer2(int[] input)
        {
            var countUp = 0;
            for (int i = 0; i < input.Length-3; i++)
            {
                if (input[i+3] > input[i]) countUp++;
            }

            return countUp;
        }
    }
}
