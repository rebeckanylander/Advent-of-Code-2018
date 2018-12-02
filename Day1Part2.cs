using System;
using System.Collections.Generic;
using System.IO;

namespace Day1
{
    class Day1Part2
    {
        static void Main(string[] args)
        {
            string[] allStrings = File.ReadAllLines("input.txt");
            Dictionary<long, string> uniqueNumbers = new Dictionary<long, string>();
            long result = 0;
            uniqueNumbers.Add(result, "");
            var duplicateDiscovered = false;
            while (!duplicateDiscovered)
            {
                for (int i = 0; i < allStrings.Length; i++)
                {
                    result += long.Parse(allStrings[i]);

                    try
                    {
                        uniqueNumbers.Add(result, "");
                    }
                    catch (Exception)
                    {
                        duplicateDiscovered = true;
                        Console.WriteLine(result);
                        throw;
                    }
                }
            }
        }
    }
}
