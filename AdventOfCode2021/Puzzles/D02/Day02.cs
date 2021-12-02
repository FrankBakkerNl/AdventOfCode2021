using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2020.Puzzles
{
    /// <summary> https://adventofcode.com/2021/day/2</summary>
    public class Day02
    {
        [Result(1813801)]
        public static int GetAnswer1(string[] input)
        {
            var last = input.Select(l => ParseLine(l)).Aggregate((0, 0), (x, y) => (x.Item1 + y.Item1, x.Item2 + y.Item2));
            return last.Item1 * last.Item2;
        }

        static (int, int ) ParseLine(string line)
        {
            var parts = line.Split(' ');
            var step = int.Parse(parts[1]);
            return parts[0] switch
            {
                "forward" => (1 * step, 0),
                "down" => (0, 1 * step),
                "up" => (0, -1 * step),
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        [Result(1960569556)]
        public static int GetAnswer2(string[] input)
        {
            var last = input.Aggregate(new state(0, 0, 0), Move);
            return last.depth * last.pos;
        }

        record state(int depth, int pos, int aim);

        static state Move(state current, string line)
        {
            var parts = line.Split(' ');
            var step = int.Parse(parts[1]);

            return parts[0] switch
            {
                "down" => current with { aim = current.aim + step },
                "up" => current with { aim = current.aim - step },
                "forward" => current with { pos = current.pos + step, depth = current.depth + (current.aim * step) },
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}