using System;
using System.Data;
using System.IO;

namespace Day1
{
    class Day1Part1
    {
       static void Main(string[] args) => Console.WriteLine(new DataTable().Compute(string.Join(' ', File.ReadAllLines("input.txt")), null));
    }
}
