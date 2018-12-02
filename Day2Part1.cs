using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day2
{
    class Day2Part1
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input2.txt");
            var twoLetters = 0;
            var threeLetters = 0;
            foreach (var prototypeId in input)
            {
                Dictionary<char, int> letterCount = new Dictionary<char, int>();
                for (int i = 0; i < prototypeId.Length; i++)
                {
                    var allLetters = prototypeId.ToHashSet<char>();
                    var currentCount = 0;
                    if (letterCount.TryGetValue(prototypeId[i], out currentCount))
                    {
                        currentCount++;
                        letterCount[prototypeId[i]]++;
                    }
                    else
                    {
                        letterCount.Add(prototypeId[i], 1);
                    }
                }
                if (letterCount.Values.Any(x => x == 2))
                {
                    twoLetters++;
                }
                if (letterCount.Values.Any(y => y == 3))
                {
                    threeLetters++;
                }
            }
            Console.WriteLine(twoLetters * threeLetters);
        }
    }
}