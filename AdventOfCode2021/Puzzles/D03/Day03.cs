using System;
using System.Linq;
using System.Xml;

namespace AdventOfCode2020.Puzzles.Day03
{
    public class Day03
    {
        [Result(1458194)]
        [TestCase(result: 198)]
        public static int GetAnswer1(string[] input)
        {
            var halfSize = input.Length / 2;

            var gamma = 0;
            var eps = 0;
            for (int i = 0; i < input[0].Length; i++)
            {
                var count = input.Count(j => j[i] == '1');

                if (count > halfSize)
                    gamma |= 1 << input[0].Length - i -1;
                else
                    eps |= 1 << input[0].Length - i -1;
            }
            return gamma * eps;
        }
        
        [Result(2829354)]
        [TestCase(result: 230)]
        public static int GetAnswer2(string[] input)
        {
            string[] remaining = input;
            int ox =0;
            
            for (int i = 0; i < input[0].Length; i++)
            {
                var halfSize = remaining.Length / 2.0;

                var count = remaining.Count(j => j[i] == '1');

                if (count >= halfSize)
                    remaining = remaining.Where(j => j[i] == '1').ToArray();
                else
                    remaining = remaining.Where(j => j[i] == '0').ToArray();

                if (remaining.Length == 1)
                {
                    ox =  Convert.ToInt32(remaining.Single(), 2);
                    break;
                }
            }

            remaining = input;
            int c02 =0;
            
            for (int i = 0; i < input[0].Length; i++)
            {
                var halfSize = remaining.Length / 2.0;

                var count = remaining.Count(j => j[i] == '0');

                if (count > halfSize)
                    remaining = remaining.Where(j => j[i] == '1').ToArray();
                else
                    remaining = remaining.Where(j => j[i] == '0').ToArray();

                if (remaining.Length == 1)
                {
                    c02 =  Convert.ToInt32(remaining.Single(), 2);
                    break;
                }
            }
            return ox * c02;
        }
    }
}