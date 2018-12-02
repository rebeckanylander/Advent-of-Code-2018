using System;
using System.IO;

namespace Day2
{
    class Day2Part2
    {
        public static void Main(string[] args)
        {
            var input = File.ReadAllLines("input2.txt");
            foreach (var item in input)
            {
                foreach (var item2 in input)
                {
                    var differingLetters = 0;
                    var diffCharPosition = 0;
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (item[i] != item2[i])
                        {
                            differingLetters++;
                            diffCharPosition = i;
                        }
                    }
                    if (differingLetters == 1)
                    {
                        Console.WriteLine(item.Remove(diffCharPosition, 1));
                    }
                }
            }
        }
    }
}
