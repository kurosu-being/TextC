using System;
using System.Linq;

namespace Practice6_1_2 {
    class Program {
        static void Main(string[] args) {
            var wNumbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
            var wLastTwoElements = wNumbers.Length >= 2 ? wNumbers.Skip(wNumbers.Length - 2) : Enumerable.Empty<int>();

            Console.WriteLine("最後から2つの要素:");
            foreach (var wElement in wLastTwoElements) {
                Console.WriteLine(wElement);
            }
        }
    }
}

